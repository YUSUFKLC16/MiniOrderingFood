using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    
    public class Cart
    {
        
        public  List<Cartline> _cartlines { get; set; } = new List<Cartline>();

             Context db = new Context();
        public  List<Cartline> GetCartlines ()
        {
             return _cartlines; 

        }

        public void addItems(int ıd, string type)
        {
            float _price = 0;
            var isthere=_cartlines.FirstOrDefault(op => op.foodId == ıd && op.foodtype == type);
           
            if (type == "burger")
            {
                _price = (db.Burgers.FirstOrDefault(op => op.Id == ıd).price);
            }
           else if (type=="kebab")
            {
                 _price = (db.Kebabs.FirstOrDefault(op => op.Id == ıd).price);
            }

            else if (type == "drink")
            {
               _price = (db.Drinks.FirstOrDefault(op => op.Id == ıd).price);
            }
           
            if (isthere == null)
            {
               
                _cartlines.Add(new Cartline()
                {

                    foodId = ıd,
                    foodtype = type,
                    quantitiy = 1,
                    price =_price
                  
                   
                });
            }
            else
            {
                isthere.quantitiy += 1;
                isthere.price = _price * isthere.quantitiy;
            }

          
        }
        public void removeItem(int ıd, string type)
        {
            var isthere = _cartlines.FirstOrDefault(op => op.foodId == ıd && op.foodtype == type);
            if (isthere.quantitiy == 1)
            {
                _cartlines.Remove(isthere);
            }
            else
            {
                isthere.quantitiy -= 1;
            }
           
          


        }

        public float totalPrice()
        {

            float totalPrice=GetCartlines().Sum(op => op.price);
            return totalPrice;
        }



    }

    public  class Cartline
    {
        public int foodId { get; set; }

        public string foodtype { get; set; }
        public int quantitiy { get; set; }

        public float price { get; set; }



    }
}

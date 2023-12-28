using Newtonsoft.Json;

namespace FoodOrder.Models
{
    public  static class extesions
    {
        public static void setoo<T>(this ISession session, string key , T value) where T:class
        {
            string jsonvalue = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonvalue);
        }

        public static T getoo<T>(this ISession session, string key) where T : class
        {
            
           string jsonvalue= session.GetString(key);
            if (jsonvalue == null)
            {
                return null;
            }
            T liste = JsonConvert.DeserializeObject<T>(jsonvalue);
            return liste;
          
        }
    }
}


let lat;
let lng;
let key = "26c7832dfa684501a4eab6a51583aa62";
let url = `https://api.opencagedata.com/geocode/v1/json?q=${lat}+${lng}&key=${key}`;
const detail = document.querySelector("#detail");
const btnbuy = document.querySelector(".buy")
const main = document.querySelector(".container")

// Fınding latering and longing  function 
findLocation = async function () {
    navigator.geolocation.getCurrentPosition(function (possition) {
        lat = possition.coords.latitude;
        lng = possition.coords.longitude;
        showmap();
    });
};

// zoom for viewpoint 
const zoom = 15;


// For removing   map's mark I will need it later
let arr = [];

// Used to load and display tile layers on the map
// Most tile servers require attribution, which you can set under `Layer`

showmap = function () {
    //FECTİNHG

    let url = `https://api.opencagedata.com/geocode/v1/json?q=${lat}+${lng}&key=${key}`;
    fetch(url).then(function (req) {
        req.json().then(function (data) {
            const components = [data.results][0][0].components;
            detail.innerHTML = "";
            detail.innerHTML = `${components.postcode}/${components.city_district}/${components.town} `;
        });
    });

    // For Map Layer
    const map = L.map("map").setView([lat, lng], zoom);
    L.tileLayer("https://tile.openstreetmap.org/{z}/{x}/{y}.png", {
        attribution:
            '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors',
    }).addTo(map);
    var x = L.marker([lat, lng])
        .addTo(map)
        .bindPopup("yemeğimi buraya getir")
        .openPopup();

    map.on("click", function (e) {
        lat = e.latlng.lat;
        lng = e.latlng.lng;

        var y = L.marker(e.latlng)
            .addTo(map)
            .bindPopup(
                L.popup({
                    autoClose: true,
                })
            )
            .setPopupContent("buraya yemeğimi getir")
            .openPopup();

        // Fetching data  For cuurent locarion of mark on 
        let url = `https://api.opencagedata.com/geocode/v1/json?q=${lat}+${lng}&key=${key}`;
        fetch(url).then(function (req) {
            req.json().then(function (data) {
                const components = [data.results][0][0].components;
                detail.value = "";
                detail.value = `${components.postcode}/${components.city_district}/${components.town} `;
            });
        });

       // showing An other mark on the map   and removes others
      map.removeLayer(x);
        arr.push(y);
        for (i = 0; i < arr.length - 1; i++) {
            map.removeLayer(arr[i]);
        }
    });
};


findLocation();

function padding() {
    btnbuy.style.padding = "18px";
    setTimeout(() => {
        btnbuy.style.padding = "10px";
    }, 20);
}

////////////// for email


//ajax
const buy = document.querySelector(".buy");
buy.addEventListener("click", () => {
    const gmail = document.querySelector(".Gmail").textContent;
    const firstname = document.querySelector("#name").textContent;
    const phoneNumber = document.querySelector("#phoneNumber").textContent;
    const adress = document.querySelector("#detail").textContent;
    


    $.post("/Email/SendEmail", { gmail, firstname, phoneNumber, adress }, function (data) {
                

        if (data == "ok") {

            let html = `<div   style="
        width: 100%;
        height: 50px;
        background-color: #a3cfbb;
        color: #146c43;
        border: 1px, solid, #a3cfbb;
      
      ">
Email hesabınıza yollanmıştır 3 saniye sonra ana menüye yönleneceksiniz
</div>`;

            
            main.insertAdjacentHTML("afterbegin", html);
            setTimeout(() => { 

                location.href = "https://localhost:44370/home/main"

            },3000)
           
         
        }

    })
});
    

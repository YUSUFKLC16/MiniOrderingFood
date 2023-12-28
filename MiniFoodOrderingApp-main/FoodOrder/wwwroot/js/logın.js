const btnSıgnIn = document.querySelector(".button");


btnSıgnIn.addEventListener("click", () => {
    const Username = document.querySelector("#user").value;
    const password = document.querySelector("#pass").value;

    $.post("logIn/LogIn", { Username, password}, function (data) {
        console.log(data);
    });
});


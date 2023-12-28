var evt = new MouseEvent("click", {
    view: window,
    bubbles: true,
    cancelable: true,
    clientX: 20,
    /* whatever properties you want to give it */
});

document.getElementById("tab-2").dispatchEvent(evt);

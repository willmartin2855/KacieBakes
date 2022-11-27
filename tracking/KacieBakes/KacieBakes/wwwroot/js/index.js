$(document).ready(function () {
    console.log("Hello js!");

    var theFORM = $("#theForm");
    theFORM.hide();

    var buyButton = $("#buyButton");
    buyButton.on("click", function () {
        console.log("buying item!");
    });

    var productInfo = $(".product-props li")
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });

});
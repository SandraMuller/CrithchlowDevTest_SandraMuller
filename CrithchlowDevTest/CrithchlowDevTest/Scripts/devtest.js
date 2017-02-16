
var units = 0;
var currency = "";

//dynamically add data for a specific product
function ViewProduct(id) {
    $.getJSON("api/DevTest/"+id)
     .done(function (data) {
         $('#tabs-1 table').append(
            '<tr><td>Description: </td><td>' + data.Description +
            '</td></tr><tr><td>Price: </td><td>' + data.Price+
            '</td></tr><tr><td>Currency: </td><td>' + data.CurrencyCode +
            '</td></tr><tr><td>Units Available: </td><td>' + data.UnitsAvailable +
            '</td></tr>');
         $('#main').hide();
         $('#product').show();
         $("#tabs").tabs();
         units = data.UnitsAvailable;
         if (data.CurrencyCode != "NZD") currency = data.CurrencyCode;
     })
}

//Buy button functionality that notifies if currency not NZD and to validty input values
function BuyPopup() {
    if (currency != "") alert("Currency not NZD");
    var quantity = parseInt(prompt("Please enter the quantity you would like:"));
    if (quantity <= units) {
        alert("Order has been added to your cart!");
        location.reload();
    } else if (isNaN(quantity)) {
        alert("It is not a number. Please enter a valid number!");
        BuyPopup();
    } else {
        alert("Your quantity (" + quantity + ") is above the current level of units we have.");
        BuyPopup();
    }
}

//Dynamically adding html and data from web api to populate the full data table
function PopulateTable() {
    $.getJSON("api/DevTest")
   .done(function (data) {
       $.each(data, function (key, item) {
           $('#tableInfo').append(
               '<tr><td>' + item.Name +
               '</td><td>' + item.Price.toFixed(2) +
               '</td><td>' + item.CurrencyCode +
               '</td><td><a onclick="ViewProduct(' + item.ID + ');">details</a>' +
               '</td></tr>');
       })
       $('#myTable').dataTable();
   })
}
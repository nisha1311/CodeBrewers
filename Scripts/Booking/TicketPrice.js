$(document).ready(function () {
    $("#NoofSeatTxtID").keyup(function () {
        var id = $("#TrainIDBookingTXT").val();
        CheckTotalAmount(id);
    });
});


function CheckTotalAmount(id) {
    debugger
    $.ajax({
        "datatype": "json",
        data: { ID: id },
        "url": "/Booking/CheckAmount",
        "type": "Get",
        "datasrc": "",
        success: function (data) {
            debugger
            var ticketprize = data.ticket_price;
            var noSeat = $("#NoofSeatTxtID").val();
            var totalamoount = noSeat * ticketprize;
            document.getElementById('totalAmountIDTXTIDd').value = totalamoount;
        }

    });
}
        
   
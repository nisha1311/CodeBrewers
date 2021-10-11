$(document).ready(function () {
    $('#btnViewUser').click(function () {
        AddViewUserdetails();






    });


});
function AddViewtraindetails() {
    $(".table tbody").remove();
    $('#getUserData').dataTable({
        "ajax": {
            "type": "GET",
            "url": "../ ViewUser/Index",
            "datatype": "json"
        },
        "columns":
            [{
                "data": "user_id",
            },
            {
                "data": "user_name",
            },
            {
                "data": "user_email",
            },
            {
                "data": "user_password",
            },
            {
                "data": "user_confirm_password",
            },
            {
                "data": "user_dob",
            },
            {
                "data": "user_location",
            },
            {
                "data": "user_status",
            },
            {
                "data": "bookings",
            }
            
            ],
    });



}
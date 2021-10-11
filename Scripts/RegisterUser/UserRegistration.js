$(document).ready(function () {


    $("#btnAddData").click(function () {
        AddRegisterUser()
    });


});


function AddRegisterUser() {
    debugger
        var Data = {
            user_name: $("#user_name").val(),
            user_email: $("#user_email").val(),
            user_password: $("#user_password").val(),
            user_confirm_password: $("#user_confirm_password").val(),
            user_dob: $("#user_dob").val(),
            user_location: $("#user_location").val(),



        };
        $.ajax({
            type: "Post",
            url: "../UserRegistration/AddUser",
            dataType: "json",
            data: JSON.stringify({ data: Data }),
            contentType: "application/json",
            success: function (comp) {
                if (comp == 1) {
                    alert("data added succesfully");

                }
                else {
                    alert("Something Went Wrong");
                }
                $("#modaladdTrain").modal('toggle');


            }
        });
    }

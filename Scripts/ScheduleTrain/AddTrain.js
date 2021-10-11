
$(document).ready(function () {
    debugger
    $.noConflict();
    GetTrainList();
    
    $("#addTrainBtn").click(function () {
        $("#addTrainBtnPOpUP").show();
        $("#UpdateTrainBtnPopUP").hide();
        
        
        $("#modaladdTrain").modal('toggle');
    });
    $("#addTrainBtnPOpUP").click(function () {
        addTrain();
    });
    $("#UpdateTrainBtnPopUP").click(function () {
        addTrain();
    });
    
});

    function GetTrainList() {
        $(".table tbody").remove();
        $('#getData').dataTable({
            "ajax": {
                "type": "GET",
                "url": "../TrainSchedule/GetTrainList",
                "datatype": "json",
                "dataSrc": "",
            },
            "columns":
                [{
                    "data": "train_number",
                },
                {
                    "data": "train_name",
                },
                {
                    "data": "train_status",
                },
                {
                    "data": "ticket_price",
                },
                {
                    "data": "total_seats",
                },
                {
                    "data": "seats_available",
                },
                {
                    "data": "boarding_location",
                },
                {
                    "data": "drop_location",
                },
                {
                    "data": "BoardingDate",
                },
                {
                    "data": "DropDate",
                },
                {
                    "data": "boarding_time",
                },
                {
                    "data": "drop_time",
                },
                {
                    "data": "days_of_running"
                },
                    {
                        "data": "train_number",
                        "render": function (data, type, full, meta) { return '<a class="btn" onclick="EditTrain(' + data + ')" >Edit</a>'; }
                    },
                {
                    "data": "train_number",
                    "render": function (data) { return '<a class="btn" onclick="DeleteTrainList(' + data + ')"> Delete</a>' }
                    },
                  
                 ],
        });


    }


    function EditTrain(id) {
        $("#addTrainBtnPOpUP").hide();
        $("#UpdateTrainBtnPopUP").show();
        $("#modaladdTrain").modal('toggle');
        $.ajax({
            "datatype": "json",
            data: { ID: id },
            "url": "../TrainSchedule/GetTrainList",
            "type": "Get",
            "datasrc": "",
            success: function (data) {
                debugger
                $("#train_number_id").val(data[0].train_number);
                $("#train_name_id").val(data[0].train_name);
                $("#train_status_id").val(data[0].train_status);
                $("#ticket_price_id").val(data[0].ticket_price);
                $("#total_seats_id").val(data[0].total_seats);
                $("#seats_available_id").val(data[0].seats_available);
                $("#boarding_location_id").val(data[0].boarding_location);
                $("#drop_location_id").val(data[0].drop_location);
                $("#boarding_date_id").val(data[0].BoardingDate);
                $("#drop_date_id").val(data[0].DropDate);
                $("#boarding_time_id").val(data[0].boarding_time);
                $("#drop_time_id").val(data[0].drop_time);
                $("#days_of_running_id").val(data[0].days_of_running);
            }
                
        });
    }

function DeleteTrainList(id) {
    var isTrue = confirm('Are you sure you want to Delete this selected train ?');
    if (isTrue) {
        $.ajax(
            {
                type: "GET", url: '../TrainSchedule/DeleteTrainByID', async: false, data: { ID: id }, dataType: "json", contentType: "application/json", success: function (comp) {
                    if (comp == 1) {
                        location.reload();
                        alert("train Deleted Succesfully.");
                       
                    }
                    else {
                        alert("Something Went Wrong");
                    }
                }
            });
    }
    
}


function addTrain() {
    var Data = {
        train_number: $("#train_number_id").val(),
        train_name: $("#train_name_id").val(),
        train_status: $("#train_status_id").val(),
        ticket_price: $("#ticket_price_id").val(),
        total_seats: $("#total_seats_id").val(),
        seats_available: $("#seats_available_id").val(),
        boarding_location: $("#boarding_location_id").val(),
        drop_location: $("#drop_location_id").val(),
        boarding_date: $("#boarding_date_id").val(),
        drop_date: $("#drop_date_id").val(),
        boarding_time: $("#boarding_time_id").val(),
        drop_time: $("#drop_time_id").val(),
        days_of_running: $("#days_of_running_id").val(),

        
    };

    $.ajax({
        type: "Post", url: "../TrainSchedule/AddTrain", dataType: "json", data: JSON.stringify({ data: Data }), contentType: "application/json", success: function (comp) {
            if (comp == 1) {
                alert("train added succesfully");

            }
            else {
                alert("Something Went Wrong");
            }
            $("#modaladdTrain").modal('toggle');

        }
    });
}





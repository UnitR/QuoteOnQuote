$(document).ready(function (id) {
            
    
    $.ajax({
            
            type: "POST",
            url: "Votes/voteCheck",
            data: {id: id, vote:1 },
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                alert(data.msg);
            },
            error: function () {
                alert("Error occured in the voting proccess!")
            }
        });

             

        });
   


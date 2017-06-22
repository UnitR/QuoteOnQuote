
function voteDown(id){
  $(document).ready(
    function(){


        $.ajax({

            type: "POST",
            url: "../Votes/voteCheck",
            data: { id: id, vote: -1 },
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (score) {
                $('#containerVotes').html(score);
            },
            error: function () {
                alert("Error occured in the voting proccess!")
            }
        });



    });
};
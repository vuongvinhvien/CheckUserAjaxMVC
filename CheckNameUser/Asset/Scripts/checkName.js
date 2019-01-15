function UserCheck() {
    $("#Status").html("Checking...");

    $.post(
        "/Home/CheckUserNameAvailablity",
        {
            userdata: $("#UserName").val()
        },
        function (data) {
            if (data == false) {
                $("#Status").html('<font color="Green">Available! You can take it </font>')
                $("#UserName").css("border-coler", "Green");
            }
            else {
                $("#Status").html('<font color="Red">This name is taken, Try another  </font>')
                $("#UserName").css("border-coler", "Red");
            }
        }

    )
}
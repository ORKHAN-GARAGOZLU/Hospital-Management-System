document.getElementById("departmentSelect").addEventListener("change", function () {
    var selectedDepartment = this.value;

    $.ajax({
        url: "/Doctor/FilterDoctors",
        type: "GET",
        data: { department: selectedDepartment },
        success: function (data) {
            $("#doctors-container").html(data);
        },
        error: function () {
            console.log("AJAX error");
        }
    });
});




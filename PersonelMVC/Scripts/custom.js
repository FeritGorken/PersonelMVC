﻿$(function () {
    $("#tblDepartmanlar").on("click", ".btnDepartmanSil", function () {
        var btn = $(this);
        bootbox.confirm("Departmanı silmek istediğinizden emin misiniz?", function (result) {
            if (result) {
                var id = btn.data("id");
                $.ajax({
                    type: "GET",
                    url: "/Departman/Sil/" + id,
                    success: function () {
                        btn.closest("tr").remove();
                    }
                });
            }
        });
    });
});

function CheckDateTimeChange(dateElement) {
    var value = $(dateElement).val();
    if (value == '') {
        $(dateElement).valid("false");
    }
    else {
        $(dateElement).valid();
    }
}
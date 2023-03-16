$(document).ready(function () {
    $(".btn-add").on("click", function () {
        $("#modalAddUpdateCategory").modal("show");
        $("#hiddenId").val("0");
        $("#txtName").val("");
        $("#txtDescription").val("");
    });

    $("#frmAddUpdateCategory").validate({
        rules: {
            Name: {
                required: true,
                minlength: 2,
                maxlength: 15
            }
        },
        messages: {
            Name: {
                required: "Tên danh mục không được để trống",
                minlength: "Tên danh mục phải từ 6 đến 15 ký tự",
                maxlength: "Tên danh mục phải từ 6 đến 15 ký tự"
            }
        }
    });

    $(".btn-save").on("click", function () {
        if ($("#frmAddUpdateCategory").valid()) {
            var id = $("#hiddenId").val();
            var name = $("#txtName").val();
            var description = $("#txtDescription").val();
            var category = {
                Id: id,
                Name: name,
                Description: description,
            }
            $.ajax({
                url: "/Admin/Category/Save",
                data: {
                    strCategory: JSON.stringify(category)
                },
                type: "POST",
                dataType: "json",
                success: function (response) {
                    if (response.status) {
                        swal({
                            title: "Thành công",
                            type: "success",
                            confirmButtonClass: "btn-primary",
                            confirmButtonText: "OK",
                            closeOnConfirm: false,
                        }, function () {
                            window.location.href = "/Admin/Category/List";
                        });
                    }
                    else {
                        swal("Lỗi...", "", "error");
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });

            return false;
        }
    });


    $(".btn-edit").on("click", function () {
        const categoryId = $(this).data("id");
        $("#modalAddUpdateCategory").modal("show");

        $.ajax({
            url: "/Admin/Category/Get",
            data: {
                categoryId: categoryId
            },
            type: "GET",
            dataType: "json",
            success: function (response) {
                if (response.status) {
                    const data = response.data;
                    $("#hiddenId").val(data.id);
                    $("#txtName").val(data.name);
                    $("#txtDescription").val(data.description);
                } else {
                    swal("Lỗi...", "", "error");
                }
            },
            error: function () {
                swal("Lỗi...", "", "error");
            }
        });
    });

    $(".btn-delete").on("click", function () {
        const categoryId = $(this).data("id");
        swal({
            title: "Xóa danh mục này?",
            text: "",
            type: "warning",
            showCancelButton: true,
            cancelButtonText: "Hủy bỏ",
            confirmButtonClass: "btn-danger",
            confirmButtonText: "Đồng ý",
            closeOnConfirm: false,
        }, function (isConfirm) {
            if (isConfirm) {
                $.ajax({
                    url: "/Admin/Category/Delete",
                    data: {
                        categoryId: categoryId
                    },
                    type: "GET",
                    dataType: "json",
                    success: function (response) {
                        if (response.status) {
                            swal({
                                title: "Thành công",
                                type: "success",
                                confirmButtonClass: "btn-primary",
                                confirmButtonText: "OK",
                                closeOnConfirm: false,
                            }, function () {
                                window.location.href = "/Admin/Category/List";
                            });
                        }
                        else {
                            swal("Lỗi...", "", "error");
                        }
                    },
                    error: function (err) {
                        console.log(err);
                    }
                });

            } else {
                
            }
        });        
    });
});
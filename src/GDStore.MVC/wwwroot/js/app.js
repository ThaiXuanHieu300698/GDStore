const btnScroll = document.getElementById("btnScroll");

window.onscroll = function () {
    scrollFunction()
};

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        btnScroll.style.display = "block";
    } else {
        btnScroll.style.display = "none";
    }
}

function scrollToTop() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

// /
const product = document.querySelectorAll(".product");
const btnAddToCart = document.querySelectorAll(".product .btn-addToCart");



for (let i = 0; i < product.length; i++) {
    product[i].addEventListener("mouseover", el => {
        btnAddToCart[i].style.display = "block";
    });
}

for (let i = 0; i < product.length; i++) {
    product[i].addEventListener("mouseout", el => {
        btnAddToCart[i].style.display = "none";
    });
}

loadCart();

function loadCart() {
    $.ajax({
        type: 'GET',
        url: '/Cart/ListCart',
        dataType: 'json',
        success: function (res) {
            $('.lbl-cartQty').text(res.length);
        }
    });
}

$('.btn-addToCart').on('click', function () {
    const productId = $(this).data('id');
    swal({
        title: "Đã thêm vào giỏ hàng",
        type: "success",
        showCancelButton: true,
        cancelButtonText: "Tiếp tục mua sắm",
        confirmButtonClass: "btn-info",
        confirmButtonText: "Đi đến giỏ hàng",
        closeOnConfirm: false,
    },
        function () {
            window.location.href = "/Cart/Index";
        });

    $.ajax({
        url: '/Cart/AddToCart',
        data: {
            id: productId,
        },
        type: 'POST',
        dataType: 'json',
        success: function (res) {
            $('.lbl-cartQty').text(res.length);
        },
        error: function (err) {
            console.log(err);
        }
    });
});

$('.btn-buy').on('click', function () {
    const productId = $(this).data('id');

    $.ajax({
        url: '/Cart/AddToCart',
        data: {
            id: productId,
        },
        type: 'POST',
        dataType: 'json',
        success: function (res) {
            $('.lbl-cartQty').text(res.length);
            window.location.href = "/Cart/Index";
        },
        error: function (err) {
            console.log(err);
        }
    });
});


//btnAddToCart.forEach(e => e.addEventListener("click", function() {
//  swal({
//    title: "Đã thêm vào giỏ hàng",
//    type: "success",
//    showCancelButton: true,
//    cancelButtonText: "Tiếp tục mua sắm",
//    confirmButtonClass: "btn-info",
//    confirmButtonText: "Đi đến giỏ hàng",
//    closeOnConfirm: false,
//  },
//  function(){
//    window.location.href = "/Cart/Index";
//  });
//}));
// /

const imgs = document.querySelectorAll(".img-item img");

imgs.forEach(element => element.addEventListener("click", changeImgDefault));

function changeImgDefault(e) {
    const source = e.target.getAttribute("src");
    const imgDefault = document.querySelector(".img-default-product");
    const imgClicked = document.querySelector(".is-clicked");
    imgClicked.classList.remove("is-clicked");
    imgDefault.setAttribute("src", source);
    e.target.classList.add("is-clicked");
}

const btnChooseSizes = document.querySelectorAll(".size-item");

btnChooseSizes.forEach(element => element.addEventListener("click", chooseSize));

function chooseSize(e) {
    const sizeSelected = document.querySelector(".size-selected");
    if (sizeSelected === null) {
        e.target.classList.add("size-selected");
    } else {
        sizeSelected.classList.remove("size-selected");
        e.target.classList.add("size-selected");
    }
}
// /


// /
const delegate = document.getElementById("delegate");
delegate.addEventListener("change", function () {
    if (delegate.checked) {
        document.querySelector(".customer-delegate").style.display = "";
    } else {
        document.querySelector(".customer-delegate").style.display = "none";
    }
});


getProvince();

$('#ddlProvince').on('change', function () {
    var provinceId = $(this).val();
    getDistrict(provinceId);
});

$('#ddlDistrict').on('change', function () {
    var districtId = $(this).val();
    getWards(districtId);
});

$('#ddlWards').on('change', function () {
    
});

function getProvince() {
    $.get('https://vapi.vnappmob.com/api/province/', function (data) {
        var html = '';
        html += '<option value="0">--Tỉnh/Thành phố--</option>';
        $.each(data, function (index, item) {
            for (let i = 0; i < item.length; i++) {
                html += '<option value=' + item[i].province_id + '>' + item[i].province_name + '</option>';
            }
        });
        $('#ddlProvince').html(html);
    });
}

function getDistrict(provinceId) {
    $.get('https://vapi.vnappmob.com/api/province/district/' + provinceId, function (data) {
        var html = '';
        html += '<option value="0">--Quận/Huyện--</option>';
        $.each(data, function (index, item) {
            for (let i = 0; i < item.length; i++) {
                html += '<option value=' + item[i].district_id + '>' + item[i].district_name + '</option>';
            }
        });
        $('#ddlDistrict').html(html);
    });
}

function getWards(districtId) {
    $.get('https://vapi.vnappmob.com/api/province/ward/' + districtId, function (data) {
        var html = '';
        html += '<option value="0">--Phường/Xã--</option>';
        $.each(data, function (index, item) {
            for (let i = 0; i < item.length; i++) {
                html += '<option value=' + item[i].ward_id + '>' + item[i].ward_name + '</option>';
            }
        });
        $('#ddlWards').html(html);
    });
}
$(document).ready(function () {
    loadData();

    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Cart/ListCart',
            success: function (res) {
                if (res.length === 0) {
                    $('.list-cart').append("<div class='empty-cart text-center text-danger'>Giỏ hàng trống</div>");
                    $('.total').hide();
                }
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    html += "<div class='cart-item d-flex justify-content-between'>"
                        + "<div class='img-product'>"
                        + "<img src='" + item.thumbnailImage + "' alt='' class='w-100'>"
                        + "</div>"
                        + "<div class=''>"
                        + "<p>" + item.name + "</p>"
                        + "<div class='action-cart'>"
                        + "<a href='#' class='btn-remove' data-id='" + item.productId + "'><i class='fas fa-trash'></i> Xóa</a>"
                        + "</div>"
                        + "</div>"
                        + "<div class='cart-item-price'>"
                        + "<p><strong>" + item.price + "₫</strong></p>"
                        + "<p><del>" + item.originalPrice + "₫</del> <label class='badge badge-warning'>-50%</label></p>"
                        + "</div>"
                        + "<div class='action-quantity'>"
                    if (item.quantity == 1) {
                        html += "<button class='btn-decre btn-change-qty' data-id='" + item.productId + "' disabled>-</button>"
                    } else {
                        html += "<button class='btn-decre btn-change-qty' data-id='" + item.productId + "'>-</button>"
                    }
                    html += "<input class='quantity' id='txtQuantity_" + item.productId + "' type='text' value='" + item.quantity + "'>"
                        + "<button class='btn-incre btn-change-qty' data-id='" + item.productId + "'>+</button>"
                        + "</div>"
                        + "</div>"
                        + "<hr>"



                    total += amount;
                });
                $('.list-cart').html(html);
                $('.total').text("Tổng tiền: " + total + "₫");
            }
        });
    }

    $('body').on('click', '.btn-incre', function (e) {
        e.preventDefault();
        const id = $(this).data('id');
        const quantity = parseInt($('#txtQuantity_' + id).val()) + 1;
        updateCart(id, quantity);
    });

    $('body').on('click', '.btn-decre', function (e) {
        e.preventDefault();
        const id = $(this).data('id');
        const quantity = parseInt($('#txtQuantity_' + id).val()) - 1;
        updateCart(id, quantity);
    });

    $('body').on('click', '.btn-remove', function (e) {
        e.preventDefault();
        const id = $(this).data('id');
        updateCart(id, 0);
    });

    function updateCart(id, quantity) {
        $.ajax({
            type: 'POST',
            url: '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('.lbl-cartQty').text(res.length);
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

});
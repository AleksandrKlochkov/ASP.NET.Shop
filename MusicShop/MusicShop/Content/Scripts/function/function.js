//ассинхронное дабовление в корзину
$(".add-to-cart").click(function (e) {
    e.preventDefault();
    var good_id = e.target.dataset.goodid;
    $.ajax({
        type: 'get',
        url: "/Basket/AddToCart/?goodId=" + good_id,
   //     data: { goodId:good_id},
        success: function (count) {
            //console.log(count);
            $('.cart_quantyty').html(count);
        },
        error: function () {
            alert("Error!");
        }
    });
});


//ассинхронное удаление из корзины
$(".dell-to-cart").click(function (e) {
    console.log(e);
    e.preventDefault();
    var gooddel_id = e.target.closest(".dell-to-cart").dataset.goodid;
    console.log("da",gooddel_id);
    $.ajax({
        type: 'get',
        url: "/Basket/DellToProduct/?goodId=" + gooddel_id, 
        //     data: { goodId:good_id},
        success: function (count) {
            console.log(count);
            $('.cart_quantyty').html(count);
            window.location.href = "/Basket/index";
        },
        error: function () {
            alert("Error!");
        }
    });
});

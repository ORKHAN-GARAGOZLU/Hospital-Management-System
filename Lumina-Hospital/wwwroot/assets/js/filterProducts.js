$(document).ready(function () {
    $('.widgets-category button').click(function () {
        var category = $(this).attr('product-category');

        $.ajax({
            url: '/Product/GetProductsByCategory', 
            type: 'GET',
            data: { category: category },
            success: function (data) {
                $('#product-container').html(data);
            },
            error: function () {
                alert('ajax error');
            }
        });
    });
});

$('#search-input').keyup(function () {
    var searchValue = $(this).val();
    if (searchValue.length > 0) {
        $("#search-results li").slice(1).remove();

        $.ajax({
            url: '/home/Search',
            type: 'GET',
            data: { search: searchValue },
            success: function (data) {

                $('#search-results').append(data);
            },

        });
    }
});
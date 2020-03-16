$('#searchSubmit').click(function () {
    $.ajax({
        type: "GET",
        url: "/getdata",
        //contentType: "application/json",
        //data: JSON.stringify({ SearchName:data })
    }).done((res) => { console.log(res) })
        .fail((res) => console.log(res));
})
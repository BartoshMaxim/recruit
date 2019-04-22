// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function removeImage(imageid) {
    var result = confirm("You sure about that you want delete this image?");

    if (result) {

        // var id = imageid.replace("image", "");
        //
        // $.ajax({
        //     type: "POST",
        //     url: "/Product/DeleteImage",
        //     data: {
        //         ImageId: $('div.' + imageid + ' label input').val(),
        //         ProductId: $('#ProductId').val()
        //     }
        // });

        $('div.' + imageid + ' label img').remove();
        $('div.' + imageid + ' label').attr("for", imageid);
        $('div.' + imageid + ' a').remove();
        $('div.' + imageid + ' label').text("+");
    }
};

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();


        $(reader).on("load", { value: $(input).attr('id') }, function (e) {
            var eventdata = e.data.value;

            $('div.' + eventdata + ' label').text("");
            $('div.' + eventdata).append('<a class="icon remove"></a>');

            $('div.' + eventdata + ' label').append("<img />");
            $('div.' + eventdata + ' label img').attr('src', e.target.result);
            $('div.' + eventdata + ' label').removeAttr("for");
            $('div.' + eventdata + ' a').on("click", { value: eventdata }, function (e) {
                var eventval = e.data.value;
                $('#' + eventval + '').val("");
                //$('#' + eventval).attr("type", "file");
                $('div.' + eventval + ' label').text("+");
                $('div.' + eventval + ' a').remove();
                $('div.' + eventval + ' label img').remove();
                $('div.' + eventval + ' label').attr("for", eventval);
            });
        });
        reader.readAsDataURL(input.files[0]);
    }
};
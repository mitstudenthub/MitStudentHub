// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function HandleBrowseClick() {
    var fileinput = document.getElementById("input_upload_img_job_post");
    fileinput.click();
}

function Handlechange() {
    var Post_img = document.getElementById("img_job_post");
    var fileinput = document.getElementById("input_upload_img_job_post");
    var imgVal = $('#input_upload_img_job_post').files[0];
    $("#img_job_post").attr("src", imgVal);
    $("#img_job_post").css("display", "block");
   
   
}
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#img_job_post').attr('src', e.target.result);
            $('#Imagebase64').val(e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    }
}
$("#input_upload_img_job_post").change(function () {
    readURL(this);
    $("#img_job_post").css("display", "block");
});
$("#btn_job_post").on("click", function () {
    if ($("#PostMessage").val() == null || $("#PostMessage").val() == ' ' || $("#PostMessage").val() == '') {
        $("#PostMessage").css('border-color', 'red');
    }
    else {
        $("#PostMessage").css('border-color', '#ccc');
        $("#btn_submitform_job").click();
    }
});


////////////////////Accomodation/////////////////////////////
function AccomodationHandleBrowseClick() {
    var fileinput = document.getElementById("input_upload_img_accomodation_post");
    fileinput.click();
}

function AccomodationHandlechange() {

    var Post_img = document.getElementById("img_accomodation_post");
    var fileinput = document.getElementById("input_upload_img_accomodation_post");
    var imgVal = $('#input_upload_img_accomodation_post').files[0];
    $("#img_accomodation_post").attr("src", imgVal);
    $("#img_accomodation_post").css("display", "block");


}
function readURLAccomodation(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#img_accomodation_post').attr('src', e.target.result);
            $('#Imagebase64').val(e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    }
}
$("#input_upload_img_accomodation_post").change(function () {
    readURLAccomodation(this);
    $("#img_accomodation_post").css("display", "block");
});
$("#btn_accomodation_post").on("click", function () {
    if ($("#PostMessage").val() == null || $("#PostMessage").val() == ' ' || $("#PostMessage").val() == '') {
        $("#PostMessage").css('border-color', 'red');
    }
    else {
        $("#PostMessage").css('border-color', '#ccc');
        $("#btn_submitform_accomodation").click();
    }
});
////////////////////Travel/////////////////////////////
function TravelHandleBrowseClick() {
    var fileinput = document.getElementById("input_upload_img_travel_post");
    fileinput.click();
}

function TravelHandlechange() {

    var Post_img = document.getElementById("img_travel_post");
    var fileinput = document.getElementById("input_upload_img_travel_post");
    var imgVal = $('#input_upload_img_travel_post').files[0];
    $("#img_travel_post").attr("src", imgVal);
    $("#img_travel_post").css("display", "block");


}
function readURLTravel(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#img_travel_post').attr('src', e.target.result);
            $('#Imagebase64').val(e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    }
}
$("#input_upload_img_travel_post").change(function () {
    readURLTravel(this);
    $("#img_travel_post").css("display", "block");
});
$("#btn_travel_post").on("click", function () {
    if ($("#PostMessage").val() == null || $("#PostMessage").val() == ' ' || $("#PostMessage").val() == '') {
        $("#PostMessage").css('border-color', 'red');
    }
    else {
        $("#PostMessage").css('border-color', '#ccc');
        $("#btn_submitform_travel").click();
    }
});

////////////////////Events/////////////////////////////
function EventHandleBrowseClick() {
    var fileinput = document.getElementById("input_upload_img_event_post");
    fileinput.click();
}

function EventHandlechange() {

    var Post_img = document.getElementById("img_event_post");
    var fileinput = document.getElementById("input_upload_img_event_post");
    var imgVal = $('#input_upload_img_event_post').files[0];
    $("#img_event_post").attr("src", imgVal);
    $("#img_event_post").css("display", "block");


}
function readURLEvent(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#img_event_post').attr('src', e.target.result);
            $('#Imagebase64').val(e.target.result);
        }
        reader.readAsDataURL(input.files[0]);
    }
}
$("#input_upload_img_event_post").change(function () {
    readURLEvent(this);
    $("#img_event_post").css("display", "block");
});
$("#btn_event_post").on("click", function () {
    if ($("#PostMessage").val() == null || $("#PostMessage").val() == ' ' || $("#PostMessage").val() == '') {
        $("#PostMessage").css('border-color', 'red');
    }
    else {
        $("#PostMessage").css('border-color', '#ccc');
        $("#btn_submitform_event").click();
    }
});



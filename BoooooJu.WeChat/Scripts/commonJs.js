function AutoSkipInit() {
    $("#AutoSkip").hide();
    $("#AutoSkip").css("height", "100%");
    $("#AutoSkip").css("width", "100%");
    $("#AutoSkip").css("position", "fixed");
    $("#AutoSkip").css("top", "0");
    $("#AutoSkip").css("left", "0");
    $("#AutoSkip").css("background", "black");
    $("#AutoSkip").css("opacity", "0.8");
    $("#AutoSkip").css("text-align", "center");
    $("#AutoSkip").css("z-index", "99999");
    $("#AutoSkip").append("<p></p>");
    $("#AutoSkip").children('p').css("color", "white");
    $("#AutoSkip").children('p').css("font-size", "14px");
    $("#AutoSkip").children('p').css("position", "absolute");
    $("#AutoSkip").children('p').css("top", "50%");
    $("#AutoSkip").children('p').css("margin-top", "-8px");
    $("#AutoSkip").children('p').css("width", "100%");
    $("#AutoSkip").children('p').css("vertical-align", "central");
    $("#AutoSkip").children('p').css("text-align", "center");
    $("#AutoSkip").bind("click", function () {
        $(this).hide();
    });
}
function AutoSkip(tips, url, timeSpan) {
    $("#AutoSkip").children('p').text(tips);
    $("#AutoSkip").show();
    if (timeSpan > 0) {
        timeSpan = timeSpan * 1000;
    } else {
        timeSpan = 3000;
    }
    setTimeout(function () {
        $("#AutoSkip").hide();
        if (url != "" && url != undefined) {
            window.location.href = url;
        }
    }, timeSpan);
}

function SignOut() {
    $.ajax({
        url: "/Account/SignOut",
        type: "post",
        success: function (e) {
            if (e) {
                location.reload();
            }
        }
    });
}
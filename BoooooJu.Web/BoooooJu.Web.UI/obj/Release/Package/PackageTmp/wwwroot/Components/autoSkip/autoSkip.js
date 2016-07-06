var autoSkipId = "AutoSkip";
function AutoSkipInit(id) {
    if (id != undefined)
        autoSkipId = id;
    var $autoSkip = $("#" + autoSkipId);
    if ($autoSkip.length > 0) {
        $autoSkip.hide();
        $autoSkip.css("height", "100%")
        .css("width", "100%")
        .css("position", "fixed")
        .css("top", "0")
        .css("left", "0")
        .css("background", "black")
        .css("opacity", "0.8")
        .css("text-align", "center")
        .css("z-index", "99999");

        $autoSkip.append("<p></p>");
        $p = $autoSkip.children('p');
        $p.css("color", "white")
            .css("font-size", "14px")
            .css("position", "absolute")
            .css("top", "50%")
            .css("margin-top", "-8px")
            .css("width", "100%")
            .css("vertical-align", "central")
            .css("text-align", "center");
        $autoSkip.bind("click", function () {
            $(this).hide();
        });
    }
}

function AutoSkip(tips, url, timeSpan) {
    var $autoSkip = $("#" + autoSkipId);
    $autoSkip.children('p').text(tips);
    $autoSkip.show();
    if (timeSpan > 0) {
        timeSpan = timeSpan * 1000;
    } else {
        timeSpan = 3000;
    }
    setTimeout(function () {
        $autoSkip.hide();
        if (url != "" && url != undefined) {
            window.location.href = url;
        }
    }, timeSpan);
}
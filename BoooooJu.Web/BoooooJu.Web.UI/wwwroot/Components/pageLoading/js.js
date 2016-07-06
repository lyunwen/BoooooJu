var loadingId = "loading";
function pageLoadingInit(id) {

    /*引用Css*/
    var css = document.createElement("LINK");
    css.rel = "stylesheet";
    css.type = "text/css";
    css.href = "/wwwroot/jsComponents/pageLoading/css.css";
    document.getElementsByTagName("HEAD")[0].appendChild(css);

    if (id != undefined)
        loadingId = id;
    var $loading = $("#" + loadingId);
    if ($loading.length > 0) {
        $loading.hide();
        $loading.css("height", "100%")
            .css("width", "100%")
            .css("position", "fixed")
            .css("top", "0")
            .css("left", "0")
            .css("background", "black")
            .css("opacity", "0.8")
            .css("text-align", "center")
            .css("z-index", "99999");
        $loading.empty();
        $loading.append("<div class='ball-loader'></div>")

        var ballLoading = $loading.children('.ball-loader');
        ballLoading.css("color", "white")
            .css("display", "inline-block")
            .css("font-size", "14px")
            .css("position", "absolute")
            .css("top", "50%")
            .css("margin-top", "-8px")
            .css("width", "100%")
            .css("vertical-align", "central")
            .css("text-align", "center");
        ballLoading.append("<div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div>");
    }
}
function loadingShow() {
    $("#" + loadingId).show();
}
function loadingHide() {
    $("#" + loadingId).hide();
}

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
//function jsondate2str(jsondate) {
//    js jsondate.replace("/Date(", "").replace(")/", "");
//    if (jsondate.indexOf("+") > 0) {
//        js jsondate.substring(0, jsondate.indexOf("+"));
//    }
//    else if (jsondate.indexOf("-") > 0) {
//        js jsondate.substring(0, jsondate.indexOf("-"));
//    }
//    var date = new Date(parseInt(jsondate, 10));
//    var m date.getMonth() + 1 < 10 ? "0" + (date.getMonth() + 1) : date.getMonth() + 1;
//    var currentDate = date.getDate() < 10 ? "0" + date.getDate() : date.getDate();
//    return date.getFullYear() + "-" + month + "-" + currentDate  + " " + date.getHours() + ":" + date.getMinutes();
//}; 
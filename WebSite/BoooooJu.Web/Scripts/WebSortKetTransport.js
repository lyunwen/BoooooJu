//WebSorcket客户端脚本
var Socket_Socket = null;
var Socket_Info = { isLink: false, type: 1, linkMsg: "", transData: null };
function Socket_Init(userName, pswd, sorketUrl) {
    if ("WebSocket" in window) {
        Socket_Socket = new WebSocket(sorketUrl);
    }
    else if ("MozWebSocket" in window) {
        Socket_Socket = new MozWebSocket(sorketUrl);
    } else {
        Socket_Info.isLink = false;
        Socket_Info.linkMsg = "浏览器不支持WebSocket";
        return SocketLinkResult;
    }

    Socket_Socket.onopen = function () {
        Socket_Info.isLink = true;
        Socket_Info.linkMsg = "连接服务器成功";
        return Socket_Info;
    }

    Socket_Socket.onclose = function () {
        Socket_Info.isLink = false;
        Socket_Info.linkMsg = "与服务器断开连接";
        return Socket_Info;
    }

    Socket_Socket.onerror = function () {
        Socket_Info.isLink = false;
        Socket_Info.linkMsg = "通信发生错误";
        return Socket_Info;
    }

    Socket_Socket.onmessage = function (msg) {
        alert(msg.data);
        Socket_Info.transData = msg.data;
    }
     
    return Socket_Info;
}
function Socket_SendMessage(message) {
    if (Socket_Info.isLink) {
        try {
            Socket_Socket.send(message);
            return Socket_Info;
        } catch (e) {
            return "发送失败";
        }
    } else {
        return "WebSocket尚未连接成功";
    }
}
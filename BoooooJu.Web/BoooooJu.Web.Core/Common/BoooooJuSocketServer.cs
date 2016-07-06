using SuperWebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Common
{
    /// <summary>
    /// 简单的WebsocketDemo
    /// </summary>
    public class BoooooJuSocketServer
    {
        private const string ip = "192.168.1.36";
        private const int port = 2012;
        private WebSocketServer ws = null;//SuperWebSocket中的WebSocketServer对象

        public BoooooJuSocketServer()
        {
            ws = new WebSocketServer();//实例化WebSocketServer
            //添加事件侦听
            ws.NewSessionConnected += ws_NewSessionConnected;//有新会话握手并连接成功
            ws.SessionClosed += ws_SessionClosed;//有会话被关闭 可能是服务端关闭 也可能是客户端关闭
            ws.NewMessageReceived += ws_NewMessageReceived;//有新文本消息被接收
            ws.NewDataReceived += ws_NewDataReceived;//有新二进制消息被接收
        }
        void ws_NewSessionConnected(WebSocketSession session)
        {
            Console.WriteLine("{0:HH:MM:ss}  与客户端:{1}创建新会话", DateTime.Now, session.RemoteEndPoint);
        }

        void ws_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            Console.WriteLine("{0:HH:MM:ss}  与客户端:{1}的会话被关闭 原因：{2}", DateTime.Now, session.RemoteEndPoint, value);
        }

        void ws_NewMessageReceived(WebSocketSession session, string value)
        {
            Console.WriteLine("{0:HH:MM:ss}  获取到客户端:{1} 发送的文本y消息:{2}", DateTime.Now, session.RemoteEndPoint, value); 
            session.Send(string.Format("{0:HH:MM:ss} 服务端已接收到消息 value:" + value + "Ip:" + session.RemoteEndPoint, DateTime.Now));//向客户端发送一个回执
        }

        void ws_NewDataReceived(WebSocketSession session, byte[] value)
        {
            Console.WriteLine("{0:HH:MM:ss} 收到来自客户端的二进制流。 长度:{1}", DateTime.Now, value.Length);
            session.Send(value, 0, value.Length);//将流发送回去 
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <returns></returns>
        public void Start()
        {
            if (!ws.Setup(ip, port))
            {
                Console.WriteLine("SimpleWebSocket 设置WebSocket服务侦听地址失败");
                return;
            }

            if (!ws.Start())
            {
                Console.WriteLine("SimpleWebSocket 启动WebSocket服务侦听失败");
                return;
            }

            Console.WriteLine("SimpleWebSocket 启动服务成功");
        }

        /// <summary>
        /// 停止侦听服务
        /// </summary>
        public void Stop()
        {
            if (ws != null)
            {
                ws.Stop();
            }
        }
    }
}

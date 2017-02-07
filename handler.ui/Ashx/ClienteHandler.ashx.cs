using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handler.ui.Ashx
{
    /// <summary>
    /// Summary description for ClienteHandler
    /// </summary>
    public class ClienteHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
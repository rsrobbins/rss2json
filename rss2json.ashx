<%@ WebHandler Language="C#" Class="rss2json" %>

using System;
using System.Web;

public class rss2json : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "application/javascript";
        string strFeed;
        strFeed = HttpContext.Current.Request.QueryString["feed"];
        // wrap in callback function
        strFeed = "var obj = eval (" + RssToJson.App_Code.RssDocument.Load(strFeed).ToJson() + ");";
        context.Response.Write(strFeed);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
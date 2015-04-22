using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using RssToJson.App_Code;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Convert_Click(object sender, EventArgs e)
    {
        string json = RssDocument.Load(RssUrl.Text).ToJson();
        ConvertedJson.Text = json;
    }
    protected void Convert2_Click(object sender, EventArgs e)
    {
        string json = RssDocument.LoadFromXml(RssXml.Text).ToJson();
        ConvertedJson2.Text = json;
    }
}


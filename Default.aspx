<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Convert Rss To JSON</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td valign="top">
                    Rss Url to Convert To JSON :
                </td>
                <td>
                    <asp:TextBox ID="RssUrl" runat="server" Width="381px">http://news.google.com/?output=rss</asp:TextBox>
                    <asp:Button ID="Convert" runat="server" OnClick="Convert_Click" Text="Convert" />
                </td>
            </tr>
            <tr>
                <td valign="top">
                    Converted to JSON :
                </td>
                <td>
                    <asp:TextBox ID="ConvertedJson" runat="server" TextMode="MultiLine" Rows="20" Columns="20"
                        Width="445px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <hr />
                </td>
            </tr>
            <tr>
                <td valign="top">
                    Xml to Convert To JSON :
                </td>
                <td valign="Top">
                    <asp:TextBox ID="RssXml" runat="server" TextMode="MultiLine" Rows="20" Columns="20"
                        Width="381px"></asp:TextBox>
                    <asp:Button ID="Convert2" runat="server" Text="Convert" OnClick="Convert2_Click" />
                </td>
            </tr>
            <tr>
                <td valign="top">
                    Converted to JSON :
                </td>
                <td>
                    <asp:TextBox ID="ConvertedJson2" runat="server" TextMode="MultiLine" Rows="20" Columns="20"
                        Width="445px"></asp:TextBox></td>
            </tr>
        </table>
    </form>
</body>
</html>

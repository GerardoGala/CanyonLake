#region Using

using System;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using BlogEngine.Core;
using BlogEngine.Core.Web.Controls;
using System.Net.Mail;
using System.Text.RegularExpressions;

#endregion

public partial class location : BlogBasePage
{
    protected override void OnInit(EventArgs e)
    {
        System.Web.UI.Page pg = (System.Web.UI.Page)HttpContext.Current.CurrentHandler;
        HtmlLink link = new HtmlLink();
        link.Attributes.Add("href", "stylePage.css");
        link.Attributes.Add("media", "screen");
        link.Attributes.Add("rel", "stylesheet");
        link.Attributes.Add("type", "text/css");
        pg.Header.Controls.Add(link);
    }

}
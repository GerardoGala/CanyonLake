using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogEngine.Core;
using BlogEngine.Core.Web.Controls;
using BlogEngine.Core.Web.Extensions;
using System.Text;

/// <summary>
/// Summary description for FacebookLike
/// </summary>
[Extension("Helps in like your Post with Facebook", "1.0", "<a href=\"http://www.isharpnote.com/\">ISHARPNOTE</a>",800)]
public class FacebookLike
{

    static protected ExtensionSettings _extensionSettings;
    private const string ExtensionName = "FacebookLike";
    public FacebookLike()
    {
        InitializeSettings();
        Post.Serving += new EventHandler<ServingEventArgs>(Post_Serving);
    }

    void Post_Serving(object sender, ServingEventArgs e)
    {
        if (e.Location == ServingLocation.Feed) return;

        bool ShowPostList = Convert.ToBoolean(_extensionSettings.GetSingleValue("ShowPostList"));
        if (e.Location == ServingLocation.PostList && !ShowPostList) return;

        Post post = sender as Post;
        ButtonSettings bSettings = new ButtonSettings();
        StringBuilder sBuild = new StringBuilder();
        sBuild.AppendLine("<div class=\"FacebookLike\">");
        string likeScript = string.Format("<iframe src=\"http://www.facebook.com/plugins/like.php?href={0}&amp;layout={1}&amp;show_faces={2}&amp;width={3}&amp;action={4}&amp;font&amp;colorscheme={5}&amp;height=80\" scrolling=\"no\" frameborder=\"0\" style=\"border:none; overflow:hidden; width:450px; height:80px;\" allowTransparency=\"true\"></iframe>",
            post.AbsoluteLink.AbsoluteUri, bSettings.Layout, bSettings.ShowFaces, bSettings.Width, bSettings.Action, bSettings.ColorScheme);
        sBuild.AppendLine(likeScript);
        sBuild.AppendLine("</div>");
        e.Body += sBuild.ToString();
    }

    private void InitializeSettings()
    {
        var settings = new ExtensionSettings(ExtensionName);
        settings.Help = "Enable facebook Like button on Post Home page and Post page";

        settings.IsScalar = true;
        settings.AddParameter("ShowPostList", "Display Like button on featured list", 20, false, false, ParameterType.Boolean);
        settings.AddParameter("ShowFaces", "Show Faces (Show profile pictures below the button)", 20, false, false, ParameterType.Boolean);
        settings.AddParameter("Width", "Width (the width of the plugin in pixel)", 20, false, false, ParameterType.String);
        settings.AddParameter("Action", "Verb to display", 20, false, false, ParameterType.DropDown);
        settings.AddValue("Action", new string [] { "like", "recommend" }, "like");
        settings.AddParameter("ColorScheme", "Color Scheme (color scheme of the plugin)", 20, false, false, ParameterType.DropDown);
        settings.AddValue("ColorScheme", new string[] { "light", "dark" }, "light");
        settings.AddParameter("SelectedLayout", "Layout Style", 20, false, false, ParameterType.DropDown);
        settings.AddValue("SelectedLayout", new string[] { "standard", "button_count", "box_count" }, "standard");
        settings.AddValue("ShowPostList", true);
        _extensionSettings = ExtensionManager.InitSettings(ExtensionName, settings);
    }


    class ButtonSettings
    {
        public string Layout { get; set; }
        public string ShowFaces { get; set; }
        public string Width { get; set; }
        public string Action { get; set; }
        public string ColorScheme { get; set; }

        public ButtonSettings()
        {
            this.Layout = _extensionSettings.GetSingleValue("SelectedLayout") ?? "standard";
            this.ShowFaces = _extensionSettings.GetSingleValue("ShowFaces") ?? "false";
            this.Width = _extensionSettings.GetSingleValue("Width") ?? "450";
            this.Action = _extensionSettings.GetSingleValue("Action") ?? "like";
            this.ColorScheme = _extensionSettings.GetSingleValue("ColorScheme") ?? "light";
        }
    }
}
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class RecordsUpload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        string sFileName = string.Empty;
        if (FUFile.PostedFile != null)
        {
            // To save file into project folder use following code

            sFileName = @"~/Records.xml";
            string path = Server.MapPath(sFileName);
            FUFile.SaveAs(path);
        }
    }
}
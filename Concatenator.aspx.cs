using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;
using System.Web.UI.HtmlControls;

public partial class Concatenator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["RecordType"] = "";
            PopulateDropdown();
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            PopulateFields(Session["RecordType"].ToString());
        }
    }
    
    protected void PopulateDropdown()
    {
        DropDownList1.Items.Add("Select the Record Type");
        StringBuilder sb = new StringBuilder();
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("~/Records.xml"));

        XmlNodeList records = doc.GetElementsByTagName("Records");
        foreach (XmlNode record in records)
        {
            foreach (XmlNode table in record.SelectNodes("*"))
            {
                DropDownList1.Items.Add(table.Name);
            }
        }
    }

    protected void PopulateFields(string tableName)
    {
        XmlDocument doc = new XmlDocument();
        doc.PreserveWhitespace = true; 
        doc.Load(Server.MapPath("~/Records.xml"));

        HtmlTable table1 = new HtmlTable();
        // Set the table's formatting-related properties.        
        table1.Border = 1;
        table1.CellPadding = 3;
        table1.CellSpacing = 3;
        table1.BorderColor = "blue";

        XmlNodeList fields = doc.GetElementsByTagName(tableName);
        foreach (XmlNode field in fields)
        {
            foreach (XmlNode column in field.SelectNodes("*"))
            {
                // Start adding content to the table.
                HtmlTableRow row;
                HtmlTableCell cell;
                row = new HtmlTableRow();
 
                cell = new HtmlTableCell();
                TextBox tb1 = new TextBox();
                tb1.MaxLength = Convert.ToInt32(column.InnerText);
                tb1.EnableViewState = true;
                tb1.ID = "txt" + column.Name;
                cell.Controls.Add(tb1);
                if (tb1.ID.Contains("Filler")) tb1.Visible = false;
                else
                {
                    Label lbl1 = new Label();
                    lbl1.Text = column.Name;
                    lbl1.ID = "lbl" + column.Name;
                    cell.Controls.Add(lbl1);
                }
                // Add the cell to the current row.
                row.Cells.Add(cell);
                table1.Rows.Add(row);
            }
        }
        PlaceHolder1.Controls.Add(table1); 

    }
    
    protected void ReadXML()
    {
        StringBuilder sb = new StringBuilder();
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("~/Records.xml"));

        XmlNodeList records = doc.GetElementsByTagName("Records");
        foreach (XmlNode record in records)
        {
            foreach (XmlNode table in record.SelectNodes("*"))
            {
                DropDownList1.Items.Add(table.Name);
                sb.AppendFormat("Record: {0}", table.Name);
                sb.AppendLine();

                foreach (XmlNode column in table.SelectNodes("*"))
                {
                    sb.AppendFormat("Column: {0}", column.Name);
                    sb.AppendFormat("Size: {0}", column.InnerText);
                    sb.AppendLine();
                }
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        PlaceHolder1.Controls.Clear(); 
        PopulateFields(DropDownList1.Text);
        Session["RecordType"] = DropDownList1.Text;
    }

   
    protected void EnterButton_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        foreach (Control control in PlaceHolder1.Controls)
        {
            if (control is HtmlTable)
            {
                HtmlTable table = (HtmlTable)control;
                foreach (HtmlTableRow row in table.Rows)
                {
                    foreach (HtmlTableCell cell in row.Cells)
                    {
                        foreach (Control control2 in cell.Controls)
                        {
                            if (control2 is TextBox)
                            {
                                TextBox tb1 = (TextBox)control2;
                                if (tb1.Visible)
                                {
                                    sb.Append(tb1.Text.PadLeft(tb1.MaxLength));
                                    tb1.Text = "";
                                }
                                else
                                    sb.Append((" ").PadRight(tb1.MaxLength));
                            }
                        }
                    }
                }
            }
        }
        if (TextBox1.Text == "")
            TextBox1.Text = sb.ToString();
        else
            TextBox1.Text = TextBox1.Text + System.Environment.NewLine + sb.ToString();

        foreach (Control control in PlaceHolder1.Controls)
        {
            if (control is TextBox)
            {
                TextBox textBox = (TextBox)control;
                textBox.Text = "";
            }
        }
    }


    protected void ClearButton_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
    }

}
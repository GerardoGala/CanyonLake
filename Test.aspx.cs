using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            Control apartmentDiv = Page.FindControl("ApartmentDiv");
            if (apartmentDiv != null)
                apartmentDiv.Visible = true;

            Control commercialDiv = Page.FindControl("CommercialDiv");
            if (commercialDiv != null)
                commercialDiv.Visible = false;

            ApartmentTextBox1.Text = "";
            ApartmentTextBox2.Text = "";
            ApartmentTextBox3.Text = "";
            ApartmentTextBox4.Text = "";
            ApartmentTextBox5.Text = "";
            ApartmentTextBox6.Text = "";
            ApartmentTextBox7.Text = "";
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ListBox1.SelectedValue == "Apartment")
        {
            Control apartmentDiv = Page.FindControl("ApartmentDiv");
            if (apartmentDiv != null)
                apartmentDiv.Visible = true;

            Control commercialDiv = Page.FindControl("CommercialDiv");
            if (commercialDiv != null)
                commercialDiv.Visible = false;
        }
        if (ListBox1.SelectedValue == "Commercial")
        {
            Control apartmentDiv = Page.FindControl("ApartmentDiv");
            if (apartmentDiv != null)
                apartmentDiv.Visible = false;

            Control commercialDiv = Page.FindControl("CommercialDiv");
            if (commercialDiv != null)
                commercialDiv.Visible = true;
        }
    }


    protected void ApartmentButton_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(ApartmentTextBox1.Text.PadLeft(10));
        sb.Append((" ").ToString().PadRight(5));
        sb.Append(ApartmentTextBox2.Text.PadLeft(20));
        sb.Append(ApartmentTextBox3.Text.PadLeft(6));
        sb.Append(ApartmentTextBox4.Text.PadLeft(6));
        sb.Append(ApartmentTextBox5.Text.PadLeft(30));
        sb.Append(ApartmentTextBox6.Text.PadLeft(2));
        sb.Append(ApartmentTextBox7.Text.PadLeft(5));
        sb.Append((" ").ToString().PadRight(20));
        TextBox1.Text = TextBox1.Text + System.Environment.NewLine + sb.ToString();
        ApartmentTextBox1.Text = "";
        ApartmentTextBox2.Text = "";
        ApartmentTextBox3.Text = "";
        ApartmentTextBox4.Text = "";
        ApartmentTextBox5.Text = "";
        ApartmentTextBox6.Text = "";
        ApartmentTextBox7.Text = "";
    }
    protected void ApartmentTextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ClearButton_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
    }
    protected void CommercialButton_Click(object sender, EventArgs e)
    {
        StringBuilder sb =  new StringBuilder();
        sb.Append(CommercialTextBox1.Text.PadLeft(10));
        sb.Append((" ").ToString().PadRight(5));
        sb.Append(CommercialTextBox2.Text.PadLeft(30));
        sb.Append(CommercialTextBox3.Text.PadLeft(2));
        sb.Append(CommercialTextBox4.Text.PadLeft(5));
        sb.Append(CommercialTextBox5.Text.PadLeft(15));
        sb.Append((" ").ToString().PadRight(20));
        sb.Append(CommercialTextBox6.Text.PadLeft(8));
        sb.Append(CommercialTextBox7.Text.PadLeft(4));
        TextBox1.Text = TextBox1.Text + System.Environment.NewLine + sb.ToString();
        CommercialTextBox1.Text = "";
        CommercialTextBox2.Text = "";
        CommercialTextBox3.Text = "";
        CommercialTextBox4.Text = "";
        CommercialTextBox5.Text = "";
        CommercialTextBox6.Text = "";
        CommercialTextBox7.Text = "";
    }
}
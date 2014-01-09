using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double amount = 0;
        bool goodAmount = double.TryParse(txtAmount.Text, out amount); //.Text calls string from text box
        //if it can be assigned as a double, if true, it passes the amount out. if false, sets it to allocated amount
        //in this case 0.
        if(!goodAmount)
        {
            Response.Write("<script> alert('Please enter a valid amount')</script>");
            txtAmount.Text = "";
            txtAmount.Focus();
            return;
        }//end good amount if statement

        double percent;
        if (rdbPercentage.SelectedItem.Text != "other")//if selected items text is not equal to other, we get % from it
        {
            percent = double.Parse(rdbPercentage.SelectedValue.ToString()); 
        }
        else
        {
            bool goodPercent = double.TryParse(txtOther.Text, out percent);
            if(!goodPercent)
            {
                Response.Write("<script> alert('Please enter a valid amount')</script>");
                txtOther.Text = "";
                txtOther.Focus();
                return;
            }
        } // end rdbPercentage if statement

        //begin calling class, constructors, and methods
        CalculateTip Tip = new CalculateTip(amount, percent); //call constructor
        lblTip.Text = Tip.TipCalculator().ToString("$##0.##");//call method TipCalculator
        lblTotal.Text = Tip.CalculateTotal().ToString("$##0.##");//call method CalculateTotal

    }
}

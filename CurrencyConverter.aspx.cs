using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            // adding Itmes to the combo box
            Currency.Items.Add(new ListItem("Euro", "0.15"));
            Currency.Items.Add(new ListItem("American Dollar", "0.17"));
            Currency.Items.Add(new ListItem("British Pound", "0.13"));
            Currency.Items.Add(new ListItem("Chinese Yuan", "1.17"));
            Currency.Items.Add(new ListItem("Japanese Yen", "19.07"));


            Result.InnerText = "Convert Turkish Liras to any other Currency";

        }

    }
    
    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal oldAmount;
        bool Success = Decimal.TryParse(US.Value, out oldAmount);
        if ((oldAmount <= 0) || (Success == false))
        {
            Result.Style["color"] = "red";
            Result.InnerText = "Specify a positive integer";
        }
        else
        {
                    
                if (Success)
                {
                    if (Currency.SelectedIndex == 0)
                    {

                        //Convert Currency to Euro
                        ListItem item = Currency.Items[Currency.SelectedIndex];
                        decimal newAmount = (oldAmount * Decimal.Parse(item.Value)) / 100;
                        Result.InnerText = oldAmount.ToString() + " Turkish Liras = ";
                        Result.InnerText += newAmount.ToString() + " " + item.Text;


                    }
                    if (Currency.SelectedIndex == 1)
                    {
                        ListItem item = Currency.Items[Currency.SelectedIndex];
                        decimal newAmount = (oldAmount * Decimal.Parse(item.Value)) / 100;
                        Result.InnerText = oldAmount.ToString() + " Turkish Liras = ";
                        Result.InnerText += newAmount.ToString() + " " + item.Text;


                    }
                    if (Currency.SelectedIndex == 2)
                    {
                        ListItem item = Currency.Items[Currency.SelectedIndex];
                        decimal newAmount = (oldAmount * Decimal.Parse(item.Value)) / 100;
                        Result.InnerText = oldAmount.ToString() + " Turkish Liras = ";
                        Result.InnerText += newAmount.ToString() + " " + item.Text;


                    }
                    if (Currency.SelectedIndex == 3)
                    {
                        ListItem item = Currency.Items[Currency.SelectedIndex];
                        decimal newAmount = (oldAmount * Decimal.Parse(item.Value)) / 100;
                        Result.InnerText = oldAmount.ToString() + " Turkish Liras = ";
                        Result.InnerText += newAmount.ToString() + " " + item.Text;



                    }
                    if (Currency.SelectedIndex == 4)
                    {
                        ListItem item = Currency.Items[Currency.SelectedIndex];
                        decimal newAmount = (oldAmount * Decimal.Parse(item.Value)) / 100;
                        Result.InnerText = oldAmount.ToString() + " Turkish Liras = ";
                        Result.InnerText += newAmount.ToString() + " " + item.Text;

                    }
                 }
           
                else
            {
                Result.InnerText = "The number you typed is not in the correct format."
                    + " Use only numbers";

            }
        }

    }
}

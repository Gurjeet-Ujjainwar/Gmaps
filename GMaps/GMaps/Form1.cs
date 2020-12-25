using System;
using System.Text;
using System.Windows.Forms;

namespace GMaps
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtboxStreet.Text;
            string city = txtboxCity.Text;
            string state = txtboxState.Text;
            string zipcode = txtboxzipcode.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("https://www.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryData.Append(street  + "+");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city  + "+");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state  + "+");
                }
               
                webBrowser1.Navigate(queryData.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}

using ComponentFactory.Krypton.Toolkit;
using RestaurantSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View.user
{
    public partial class Company : KryptonForm
    {

        CompanyInfo companyInfo = new CompanyInfo();

        public Company()
        {
            InitializeComponent();
        }


        private void Company_Load(object sender, EventArgs e)
        {
            getCompanyValues();
            setupUserAccess();
        }

        //validate Admin and manager
        public void setupUserAccess()
        {

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role);

            switch (userLoggedInRole)
            {
                case 2:
                    txtCompany.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtPhone.ReadOnly = true;

                    break;
                case 3:
                    txtCompany.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtPhone.ReadOnly = true;

                    break;
                default:

                    break;
            }

        }


        public void getCompanyValues()
        {
            companyInfo.getCompany();
            txtCompany.Text = companyInfo.company;
            txtVat.Text = companyInfo.vat;
            txtAddress.Text = companyInfo.address;
            txtPhone.Text = companyInfo.phone;
            
        }

        public void updateCompanyValue()
        {
            try
            {
                companyInfo.updateCompany = txtCompany.Text;
                companyInfo.updateVat = txtVat.Text;
                companyInfo.updateAddress = txtAddress.Text;
                companyInfo.updatePhone = txtPhone.Text;
                companyInfo.update_company();

                MessageBox.Show("Update Successful");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnCompnay_Click(object sender, EventArgs e)
        {
            updateCompanyValue();
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

      
    }
}

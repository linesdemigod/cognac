using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.View
{
    public partial class Loadingbar : KryptonForm
    {
        public Loadingbar()
        {
            InitializeComponent();
            
        }

       

        //METHOD FOR LOGIN
        public void login()
        {
            int role = Convert.ToInt32(Form1.Login_role);
            if (role == 1)
            {
                Admindasboard admindash = new Admindasboard();
                admindash.Show();
                this.Hide();
               Form1.L_role = "Super Admin";
            }
            else if (role == 2)
            {
                Admindasboard manager = new Admindasboard();
                manager.Show();
                this.Hide();
                Form1.L_role = "Manager";
            }
            else if (role == 3)
            {
                Admindasboard waiter = new Admindasboard();
                waiter.Show();
                this.Hide();
                Form1.L_role = "Cashier";
            }
        }

        //LOAD THE PROGRESS BAR
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            panel2.Width += 2;
            if (panel2.Width >= 406)
            {
                //CALL THE LOGIN METHOD
                login();
                timer2.Enabled = false;
            }
        }
    }
}

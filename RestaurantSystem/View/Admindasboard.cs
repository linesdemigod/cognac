using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
using RestaurantSystem.Controller;
using RestaurantSystem.View.report;
using RestaurantSystem.View.user;

namespace RestaurantSystem.View
{
    public partial class Admindasboard : KryptonForm
    {
        Dashboard dasboard = new Dashboard();

        public Admindasboard()
        {
            InitializeComponent();
            
        }
        
        private void Admindasboard_Load(object sender, EventArgs e)
        {
            

            this.WindowState = FormWindowState.Maximized; //Maximized

            //initialize the submenu function
            customizedDesign();
           
            setupUserAccess();
            
        }

       

        //Function to check the user login and also the check the permission he has
        #region GET PERMISSIONS
        public void setupUserAccess()
        {
            //instances of the permission class
            UserPermissions per = new UserPermissions();

            int userLoggedInRole = Convert.ToInt32(Form1.Login_role); //store role as integer

            //instance of the userpermission class
            per.getPermission();

            foreach (DataRow row in per.dt.Rows)
            {
                //assign the result to the a variable
                bool permission = Convert.ToBoolean(row["per_value"].ToString());
                string name = row["per_name"].ToString();
                int role = Convert.ToInt32(row["role_id"]);

                if (userLoggedInRole == 2 || userLoggedInRole == 3)
                {
                    databaseToolStripMenuItem.Enabled = false;
                }

                //check if the user logged and the priviledge given
                if (userLoggedInRole == role && name == "disable account")
                {
                    btnUser.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "disable cat")
                {
                    btnCategory.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "disable product")
                {
                    btnProduct.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "create user")
                {
                    btnAddUser.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "create cat")
                {
                    //create category
                    button4.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "create product")
                {
                    btnAddProduct.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "disable sales")
                {
                    btnAddOrder.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "view user")
                {
                    btnManageUser.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "delete sales")
                {
                    deleteASaleToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "price adjustment")
                {
                    priceAdjustmentToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "quantity adjustment")
                {
                    quantityAdjustmentToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "add expenses")
                {
                    addExpensesToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "edit expenses")
                {
                    editExpensesToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "view report")
                {
                    reportsToolStripMenuItem.Enabled = permission;
                    btnReport.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "company")
                {
                    companyToolStripMenuItem.Enabled = permission;
                    btnCompany.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "backup")
                {
                    backupToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "permissions")
                {
                    priviledgeToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "create cust")
                {
                    newCustomerToolStripMenuItem.Enabled = permission;

                }

                if (userLoggedInRole == role && name == "edit cust")
                {
                    customerListToolStripMenuItem.Enabled = permission;

                }
                
            }
            
            
        }
        #endregion

       

        //HIDE SUBMENU WHEN THE PROGRAM STARTS
        private void customizedDesign()
        {
            panelUserMenu.Visible = false;
            panelCateMenu.Visible = false;
            panelProMenu.Visible = false;
            panelReportMenu.Visible = false;
            panelOrderMenu.Visible = false;
        }

        //FUNCTION TO HIDE THE SUBMENU
        #region HIDE DESIGN
        private void hideSubmenu()
        {
            if (panelUserMenu.Visible == true)
            {
                panelUserMenu.Visible = false;
            }

            if (panelCateMenu.Visible == true)
            {
                panelCateMenu.Visible = false;
            }

            if (panelProMenu.Visible == true)
            {
                panelProMenu.Visible = false;
            }

            if (panelReportMenu.Visible == true)
            {
                panelReportMenu.Visible = false;
            }

            if (panelOrderMenu.Visible == true)
            {
                panelOrderMenu.Visible = false;
            }


        }
        #endregion

        //FUNCTION TO SHOW THE SUBMENU
        private void showSubmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hideSubmenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubmenu(panelUserMenu);
        }

        #region UserSubmenu
        private void btnAddUser_Click(object sender, EventArgs e)
        {
             Adduser user = new Adduser();
            //user.ShowDialog();
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            Manageuser user = new Manageuser();
            //user.ShowDialog();
            
           user.TopLevel = false;
           //this.WindowState = FormWindowState.Maximized;
           user.FormBorderStyle = FormBorderStyle.None;
           user.Dock = DockStyle.Fill;
           panelMain.Controls.Add(user);
           panelMain.Tag = user;
           user.BringToFront();
           user.Show();
           
            hideSubmenu(); 
       }
       #endregion UserSubmenu

       private void btnCategory_Click(object sender, EventArgs e)
       {
           showSubmenu(panelCateMenu);
       }

       #region CategorySubmenu
       private void button4_Click(object sender, EventArgs e)
       {
           Addcategory user = new Addcategory();
           // user.ShowDialog();
            
           user.TopLevel = false;
           //this.WindowState = FormWindowState.Maximized;
           user.FormBorderStyle = FormBorderStyle.None;
           user.Dock = DockStyle.Fill;
           panelMain.Controls.Add(user);
           panelMain.Tag = user;
           user.BringToFront();
           user.Show();
           
            hideSubmenu(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Managecategory user = new Managecategory();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu();
        }

        #endregion CategorySubmenu

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelProMenu);
        }

        #region ProductSubmenu
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Addproduct user = new Addproduct();
           // user.ShowDialog();
            
           user.TopLevel = false;
           //this.WindowState = FormWindowState.Maximized;
           user.FormBorderStyle = FormBorderStyle.None;
           user.Dock = DockStyle.Fill;
           panelMain.Controls.Add(user);
           panelMain.Tag = user;
           user.BringToFront();
           user.Show();
           
            hideSubmenu(); 
       }

       private void btnManageProduct_Click(object sender, EventArgs e)
       {
           Manageproduct user = new Manageproduct();
           // user.ShowDialog();
            
          user.TopLevel = false;
          //this.WindowState = FormWindowState.Maximized;
          user.FormBorderStyle = FormBorderStyle.None;
          user.Dock = DockStyle.Fill;
          panelMain.Controls.Add(user);
          panelMain.Tag = user;
          user.BringToFront();
          user.Show();
          
            hideSubmenu(); 
       }

       #endregion ProductSubmenu

      private void btnReport_Click(object sender, EventArgs e)
       {

            showSubmenu(panelReportMenu);
       }

       #region ReportSubMenu
       private void btnProductWise_Click(object sender, EventArgs e)
       {
            Productreport user = new Productreport();
            user.ShowDialog();
            
            /*user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu();*/
        }

        private void btnTotalWise_Click(object sender, EventArgs e)
        {
            Totalreport user = new Totalreport();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }
        #endregion
        private void btnOrder_Click(object sender, EventArgs e)
        {
            showSubmenu(panelOrderMenu);
        }
        #region Order Menu
        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            Order user = new Order();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }

        private void btnMagOrder_Click(object sender, EventArgs e)
        {

            Manageorder user = new Manageorder();
            //user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }

        #endregion
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to logout? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }
        }

       
        

        private void btnCompany_Click(object sender, EventArgs e)
        {
            Company user = new Company();
           // user.ShowDialog();
            
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
            
            hideSubmenu(); 
        }


        //menustrip to handle the backup
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company user = new Company();
            // user.ShowDialog();

            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }
        

        //menustrip to handle the make sales
        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order user = new Order();
            //user.ShowDialog();

            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }

        //menustrip to handle call the report item list
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReportCheck report = new ProductReportCheck();
            report.ShowDialog();
        }

        //menustrip to handle the quantity adjustment 
        private void quantityAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuantityAdjustment user = new QuantityAdjustment();
            // user.ShowDialog();

            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }

        //menustrip to handle about form
        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About user = new About();
            user.ShowDialog();
        }

        //menustrip to handle the price adjustment form
        private void priceAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceAjustment user = new PriceAjustment();
            // user.ShowDialog();

            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }

        //menustrip to handle the sales report
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntireSalesReports report = new EntireSalesReports();
            report.ShowDialog();
        }
        

        //menustrip to handle profile
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile user = new Profile();
            //user.ShowDialog();

            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();


            hideSubmenu();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReports report = new SalesReports();
            report.ShowDialog();
        }

        private void salesGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Manageorder user = new Manageorder();
            //user.ShowDialog();

            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();

            hideSubmenu();
        }

        //menustrip to delete sales
        private void deleteASaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOrder user = new DeleteOrder();
            user.ShowDialog();
        }

        //menustrip for pricehistory
        private void priceAdjustmentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceHistorys user = new PriceHistorys();
            user.ShowDialog();
        }

        private void quantityAdjustmentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QantityHistorys user = new QantityHistorys();
            user.ShowDialog();
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesGraphReports user = new SalesGraphReports();
            user.ShowDialog();
        }

        private void addExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpensesRecords user = new ExpensesRecords();
            user.ShowDialog();
        }

        private void editExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageExpenses user = new ManageExpenses();
            user.ShowDialog();
        }

        private void financialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialReports user = new FinancialReports();
            user.ShowDialog();
        }

        private void priviledgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPermission user = new UserPermission();
            user.ShowDialog();
           
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer user = new Customer();
            user.ShowDialog();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer user = new ManageCustomer();
            user.ShowDialog();
        }

        private void customerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerHistory user = new CustomerHistory();
            //user.ShowDialog();
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();

            hideSubmenu();
        }

        //make backup when form is closed
        private void Admindasboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                Backups backup = new Backups();
                
                backup.createFolder();
                backup.backup();
           
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            license.About about = new license.About();
            about.ShowDialog();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databse.DatabaseConn user = new databse.DatabaseConn();
            user.ShowDialog();
        }

        private void waiterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReport user = new CustomerReport();
            user.ShowDialog();
        }

        private void waiterTempReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTemp user = new CustomerTemp();
            user.ShowDialog();
        }
    }
}

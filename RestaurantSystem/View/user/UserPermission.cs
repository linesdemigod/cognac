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
    public partial class UserPermission : KryptonForm
    {
        UserPermissions prev = new UserPermissions();

        public UserPermission()
        {
            InitializeComponent();
        }

        
        private void UserPermission_Load(object sender, EventArgs e)
        {
            getPermissions();
        }

        //priviledge with datatable
        
        private void getPermissions()
        {
            prev.getPermission();

            foreach (DataRow row in prev.dt.Rows)
            {
                string name = row["per_name"].ToString();
                string role = row["role_id"].ToString();
                bool value = Convert.ToBoolean(row["per_value"].ToString());

                //for the Manager
                #region Manager
                if (name == "create user" && role == "2")
                {
                    checkBoxMagCreateUser.Checked = value;
                }

                if (name == "view user" && role == "2")
                {
                    checkBoxMagViewUser.Checked = value;
                }

                if (name == "disable account" && role == "2")
                {
                    checkBoxMagDisUserPanel.Checked = value;
                }

                if (name == "delete user" && role == "2")
                {
                    checkBoxMagDelUser.Checked = value;
                }


                if (name == "update user" && role == "2")
                {
                    checkBoxMagUpdateUser.Checked = value;
                }

                if (name == "disable cat" && role == "2")
                {
                    checkBoxMagDisCategory.Checked = value;
                }

                if (name == "delete cat" && role == "2")
                {
                    checkBoxMagDelCategory.Checked = value;
                }

                if (name == "update cat" && role == "2")
                {
                    checkBoxMagUpdateCategory.Checked = value;
                }

                if (name == "create cat" && role == "2")
                {
                    checkBoxMagCreateCategory.Checked = value;
                }

                if (name == "disable product" && role == "2")
                {
                    checkBoxMagDisProductPanel.Checked = value;
                }

                if (name == "create product" && role == "2")
                {
                    checkBoxMagCreateProduct.Checked = value;
                }

                if (name == "update product" && role == "2")
                {
                    checkBoxMagUpdateProduct.Checked = value;
                }

                if (name == "delete product" && role == "2")
                {
                    checkBoxMagDelProduct.Checked = value;
                }

                if (name == "price adjustment" && role == "2")
                {
                    checkBoxMagPriceAdj.Checked = value;
                }

                if (name == "quantity adjustment" && role == "2")
                {
                    checkBoxMagQuantityAdj.Checked = value;
                }

                if (name == "disable sales" && role == "2")
                {
                    checkBoxMagDisSales.Checked = value;
                }

                if (name == "delete sales" && role == "2")
                {
                    checkBoxMagDelReceipt.Checked = value;
                }

                if (name == "add expenses" && role == "2")
                {
                    checkBoxMagAddExpense.Checked = value;
                }

                if (name == "update expenses" && role == "2")
                {
                    checkBoxMagUpdateExpense.Checked = value;
                }

                if (name == "delete expenses" && role == "2")
                {
                    checkBoxMagDelExpense.Checked = value;
                }

                if (name == "view report" && role == "2")
                {
                    checkBoxMagViewReport.Checked = value;
                }

                if (name == "permissions" && role == "2")
                {
                    checkBoxMagDisPermission.Checked = value;
                }

                if (name == "company" && role == "2")
                {
                    checkBoxMagDisCompany.Checked = value;
                }

                if (name == "backup" && role == "2")
                {
                    checkBoxMagRestoreBackup.Checked = value;
                }

                if (name == "edit expenses" && role == "2")
                {
                    checkBoxMagEditExpenses.Checked = value;
                }

                if (name == "create cust" && role == "2")
                {
                    checkBoxMagCreateCust.Checked = value;
                }

                if (name == "edit cust" && role == "2")
                {
                    checkBoxMagEditCust.Checked = value;
                }
                #endregion

                //for the cashier
                #region Cashier

                //User check
                if (name == "create user" && role == "3")
                {
                    checkBoxCashCreateUser.Checked = value;
                }

                if (name == "view user" && role == "3")
                {
                    checkBoxCashViewUser.Checked = value;
                }

                if (name == "disable account" && role == "3")
                {
                    checkBoxCashDisUserPanel.Checked = value;
                }

                if (name == "delete user" && role == "3")
                {
                    checkBoxCashDelUser.Checked = value;
                }


                if (name == "update user" && role == "3")
                {
                    checkBoxCashUpdateUser.Checked = value;
                }

                if (name == "disable cat" && role == "3")
                {
                    checkBoxCashDisCategoryPanel.Checked = value;
                }

                if (name == "delete cat" && role == "3")
                {
                    checkBoxCashDelCategory.Checked = value;
                }

                if (name == "update cat" && role == "3")
                {
                    checkBoxCashUpdateCategory.Checked = value;
                }

                if (name == "create cat" && role == "3")
                {
                    checkBoxCashCreateCategory.Checked = value;
                }

                if (name == "disable product" && role == "3")
                {
                    checkBoxCashDisProductPanel.Checked = value;
                }

                if (name == "create product" && role == "3")
                {
                    checkBoxCashCreateProduct.Checked = value;
                }

                if (name == "update product" && role == "3")
                {
                    checkBoxCashUpdateProduct.Checked = value;
                }

                if (name == "delete product" && role == "3")
                {
                    checkBoxCashDelProduct.Checked = value;
                }

                if (name == "price adjustment" && role == "3")
                {
                    checkBoxCashPriceAdj.Checked = value;
                }

                if (name == "quantity adjustment" && role == "3")
                {
                    checkBoxCashQuantityAdj.Checked = value;
                }

                if (name == "disable sales" && role == "3")
                {
                    checkBoxCashDisSales.Checked = value;
                }

                if (name == "delete sales" && role == "3")
                {
                    checkBoxCashDisDelReceipt.Checked = value;
                }

                if (name == "add expenses" && role == "3")
                {
                    checkBoxCashDisAddExpense.Checked = value;
                }

                if (name == "update expenses" && role == "3")
                {
                    checkBoxCashUpdateExpense.Checked = value;
                }

                if (name == "delete expenses" && role == "3")
                {
                    checkBoxCashDelExpense.Checked = value;
                }

                if (name == "view report" && role == "3")
                {
                    checkBoxCashViewReport.Checked = value;
                }

                if (name == "permissions" && role == "3")
                {
                    checkBoxCashDisPermission.Checked = value;
                }

                if (name == "company" && role == "3")
                {
                    checkBoxCashDisCompany.Checked = value;
                }

                if (name == "backup" && role == "3")
                {
                    checkBoxCashsRestoreBackup.Checked = value;
                }

                if (name == "edit expenses" && role == "3")
                {
                    checkBoxCashEditExpenses.Checked = value;
                }

                if (name == "create cust" && role == "3")
                {
                    checkBoxCashCreateCust.Checked = value;
                }

                if (name == "edit cust" && role == "3")
                {
                    checkBoxCashEditCust.Checked = value;
                }

                #endregion


            }

        }


        //save the permission to database
        private void setPermissions()
        {
            prev.getPermission();
          

            foreach (DataRow row in prev.dt.Rows)
            {

                string name = row["per_name"].ToString();
                string role = row["role_id"].ToString();
                string id = row["per_id"].ToString();
                bool value = Convert.ToBoolean(row["per_value"].ToString());

                //for the Manager
                #region Manager
                if (name == "create user" && role == "2")
                {
                    
                    if (checkBoxMagCreateUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "view user" && role == "2")
                {
                    
                    if (checkBoxMagViewUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "disable account" && role == "2")
                {
                    
                    if (checkBoxMagDisUserPanel.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete user" && role == "2")
                {
                  
                    if (checkBoxMagDelUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }


                if (name == "update user" && role == "2")
                {
                     
                    if (checkBoxMagUpdateUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "disable cat" && role == "2")
                {
                    
                    if (checkBoxMagDisCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete cat" && role == "2")
                {
                    
                    if (checkBoxMagDelCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "update cat" && role == "2")
                {
                    
                    if (checkBoxMagUpdateCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "create cat" && role == "2")
                {
                    if (checkBoxMagCreateCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "disable product" && role == "2")
                {
                    if (checkBoxMagDisProductPanel.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "create product" && role == "2")
                {
                    
                    if (checkBoxMagCreateProduct.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "update product" && role == "2")
                {
                    
                    if (checkBoxMagUpdateProduct.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "delete product" && role == "2")
                {
                    
                    if (checkBoxMagDelProduct.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "price adjustment" && role == "2")
                {
                    
                    if (checkBoxMagPriceAdj.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "quantity adjustment" && role == "2")
                {
                    
                    if (checkBoxMagQuantityAdj.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "disable sales" && role == "2")
                {
                    
                    if (checkBoxMagDisSales.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "delete sales" && role == "2")
                {
                    
                    if (checkBoxMagDelReceipt.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "add expenses" && role == "2")
                {
                    
                    if (checkBoxMagAddExpense.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "update expenses" && role == "2")
                {
                    
                    if (checkBoxMagUpdateExpense.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "delete expenses" && role == "2")
                {
                    
                    if (checkBoxMagDelExpense.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "view report" && role == "2")
                {
                    
                    if (checkBoxMagViewReport.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "permissions" && role == "2")
                {
                    
                    if (checkBoxMagDisPermission.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "company" && role == "2")
                {
                    
                    if (checkBoxMagDisCompany.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "backup" && role == "2")
                {
                    
                    if (checkBoxMagRestoreBackup.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }


                if (name == "edit expenses" && role == "2")
                {

                    if (checkBoxMagEditExpenses.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "create cust" && role == "2")
                {

                    if (checkBoxMagCreateCust.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }

                if (name == "edit cust" && role == "2")
                {

                    if (checkBoxMagEditCust.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";

                    }
                }
                #endregion

                //for the cashier
                #region Cashier

                //User check
                if (name == "create user" && role == "3")
                {
                    
                    if (checkBoxCashCreateUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "view user" && role == "3")
                {
                    
                    if (checkBoxCashViewUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "disable account" && role == "3")
                {
                    
                    if (checkBoxCashDisUserPanel.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete user" && role == "3")
                {
                    
                    if (checkBoxCashDelUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }


                if (name == "update user" && role == "3")
                {
                   
                    if (checkBoxCashUpdateUser.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "disable cat" && role == "3")
                {
                    
                    if (checkBoxCashDisCategoryPanel.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete cat" && role == "3")
                {
                    
                    if (checkBoxCashDelCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "update cat" && role == "3")
                {
                    
                    if (checkBoxCashUpdateCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "create cat" && role == "3")
                {
                   
                    if (checkBoxCashCreateCategory.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "disable product" && role == "3")
                {
                    
                    if (checkBoxCashDisProductPanel.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "create product" && role == "3")
                {
                    
                    if (checkBoxCashCreateProduct.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "update product" && role == "3")
                {
                    
                    if (checkBoxCashUpdateProduct.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete product" && role == "3")
                {
                    
                    if (checkBoxCashDelProduct.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "price adjustment" && role == "3")
                {
                    
                    if (checkBoxCashPriceAdj.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "quantity adjustment" && role == "3")
                {
                    
                    if (checkBoxCashQuantityAdj.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "disable sales" && role == "3")
                {
                    
                    if (checkBoxCashDisSales.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete sales" && role == "3")
                {
                    
                    if (checkBoxCashDisDelReceipt.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "add expenses" && role == "3")
                {
                    
                    if (checkBoxCashDisAddExpense.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "update expenses" && role == "3")
                {
                    
                    if (checkBoxCashUpdateExpense.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "delete expenses" && role == "3")
                {
                    
                    if (checkBoxCashDelExpense.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "view report" && role == "3")
                {
                    
                    if (checkBoxCashViewReport.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "permissions" && role == "3")
                {
                    
                    if (checkBoxCashDisPermission.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "company" && role == "3")
                {
                    
                    if (checkBoxCashDisCompany.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "backup" && role == "3")
                {
                    
                    if (checkBoxCashsRestoreBackup.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "edit expenses" && role == "3")
                {

                    if (checkBoxCashEditExpenses.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "create cust" && role == "3")
                {

                    if (checkBoxCashCreateCust.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                if (name == "edit cust" && role == "3")
                {

                    if (checkBoxCashEditCust.Checked)
                    {
                        prev.id = id;
                        prev.value = "true";


                    }
                    else
                    {
                        prev.id = id;
                        prev.value = "false";


                    }
                }

                #endregion

                //save the permission
                prev.setPermissions();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setPermissions();
            MessageBox.Show("Saved");
        }
    }
}

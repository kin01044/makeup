using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestKim319
{
    public partial class FormMenu : Form
    {
        private MySqlConnection myconnection;
        public static string test;

        public FormMenu()
        {
            InitializeComponent();
            string strConn = "Server=localhost; Database=makeup; Uid=root; Pwd=apmsetup; Charset=UTF8";
            myconnection = new MySqlConnection(strConn);
        }

        private bool OpenConnection()
        {
            try
            {
                myconnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                myconnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (this.OpenConnection() == true)
            {
                string mySelectQuery = "SELECT makeupname, makeupuse, makeupprice, makeupvol, makeupskin FROM makeupd WHERE makeupsort = '" + test + "'";
                MySqlCommand mycommand = new MySqlCommand(mySelectQuery, myconnection);
                MySqlDataReader myReader = mycommand.ExecuteReader();
                while (myReader.Read())
                {
                    string[] row1 = new string[] {
                        myReader.GetString(0), myReader.GetString(1),
                        String.Format("{0:N0}",myReader.GetInt32(2)).ToString(),
                        myReader.GetInt32(3).ToString(), myReader.GetString(4) 
                    };
                    dataGridView1.Rows.Add(row1);
                }
                this.CloseConnection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String a = this.dataGridView1[0, e.RowIndex].Value.ToString();
            if (this.OpenConnection() == true)
            {
                string mySelectQuery = "SELECT makeupfab, makeupudate, makeuping FROM makeupd WHERE makeupname = '" + a + "'";
                MySqlCommand mycommand = new MySqlCommand(mySelectQuery, myconnection);
                MySqlDataReader myReader = mycommand.ExecuteReader();
                while (myReader.Read())
                {
                    lblFab.Text = myReader.GetString(0);
                    lblUdate.Text = myReader.GetInt32(1).ToString();
                    lblIng.Text = myReader.GetString(2);
                }
                this.CloseConnection();
            }
        }
    }
}

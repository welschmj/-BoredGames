using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoredGames
{
    public partial class frmSudoku : Form
    {
        public frmSudoku()
        {
            InitializeComponent();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void frmSudoku_Load(object sender, EventArgs e)
        {

        }

       private void txtGrid1_1_TextChanged(object sender, EventArgs e)
        {
            if (txtGrid1_1.Text != " ")
               txtGrid1_1.BackColor = System.Drawing.Color.DimGray;
        }

       private void btnExit_Click(object sender, EventArgs e)
       {
           frmMain frmMain = new frmMain();
           if (MessageBox.Show("Do you want to quit your current game?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
           { 
              this.Close();
              frmMain.Show();
              this.Close();
           }
       }

       private void txtGrid5_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_5.Text != " ")
               txtGrid5_5.BackColor = System.Drawing.Color.DimGray;
       }


    }
}

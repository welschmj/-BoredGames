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
            if (txtGrid1_1.Text.Length!=0)
                txtGrid1_1.BackColor = System.Drawing.Color.DimGray;
            else txtGrid1_1.BackColor = System.Drawing.Color.White;
        }

   

       private void txtGrid1_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_2.Text.Length != 0)
               txtGrid1_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_3.Text.Length != 0)
               txtGrid1_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_1.Text.Length != 0)
               txtGrid2_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_2.Text.Length != 0)
               txtGrid2_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_3.Text.Length != 0)
               txtGrid2_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_1.Text.Length != 0)
               txtGrid3_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_2.Text.Length != 0)
               txtGrid3_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_3.Text.Length != 0)
               txtGrid3_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_4.Text.Length != 0)
               txtGrid1_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_5.Text.Length != 0)
               txtGrid1_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_6.Text.Length != 0)
               txtGrid1_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_4.Text.Length != 0)
               txtGrid2_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_5.Text.Length != 0)
               txtGrid2_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_6.Text.Length != 0)
               txtGrid2_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_4.Text.Length != 0)
               txtGrid3_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_5.Text.Length != 0)
               txtGrid3_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_6.Text.Length != 0)
               txtGrid3_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_7.Text.Length != 0)
               txtGrid1_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_7.Text.Length != 0)
               txtGrid2_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_7.Text.Length != 0)
               txtGrid3_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_8.Text.Length != 0)
               txtGrid1_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_8.Text.Length != 0)
               txtGrid2_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_8.Text.Length != 0)
               txtGrid3_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_9.Text.Length != 0)
               txtGrid1_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_9.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_9.Text.Length != 0)
               txtGrid2_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_9.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_9.Text.Length != 0)
               txtGrid3_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_9.BackColor = System.Drawing.Color.White;
       }

      

    

     




    }
}

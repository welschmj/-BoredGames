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

      
       private void loadPuzzle()
       {
           SudokuPuzzleMaker puzz = new SudokuPuzzleMaker();

           puzz.generate();

           txtGrid1_1.Text = puzz.puzzle[0, 0].ToString();
           txtGrid1_1.Text = puzz.puzzle[0, 0].ToString();
           txtGrid1_1.Text = puzz.puzzle[0, 0].ToString();
           txtGrid1_2.Text = puzz.puzzle[0, 1].ToString();
           txtGrid1_3.Text = puzz.puzzle[0, 2].ToString();
           txtGrid1_4.Text = puzz.puzzle[0, 3].ToString();
           txtGrid1_5.Text = puzz.puzzle[0, 4].ToString();
           txtGrid1_6.Text = puzz.puzzle[0, 5].ToString();
           txtGrid1_7.Text = puzz.puzzle[0, 6].ToString();
           txtGrid1_8.Text = puzz.puzzle[0, 7].ToString();
           txtGrid1_9.Text = puzz.puzzle[0, 8].ToString();
           txtGrid2_1.Text = puzz.puzzle[1, 0].ToString();
           txtGrid2_2.Text = puzz.puzzle[1, 1].ToString();
           txtGrid2_3.Text = puzz.puzzle[1, 2].ToString();
           txtGrid2_4.Text = puzz.puzzle[1, 3].ToString();
           txtGrid2_5.Text = puzz.puzzle[1, 4].ToString();
           txtGrid2_6.Text = puzz.puzzle[1, 5].ToString();
           txtGrid2_7.Text = puzz.puzzle[1, 6].ToString();
           txtGrid2_8.Text = puzz.puzzle[1, 7].ToString();
           txtGrid2_9.Text = puzz.puzzle[2, 8].ToString();
           txtGrid3_1.Text = puzz.puzzle[2, 0].ToString();
           txtGrid3_2.Text = puzz.puzzle[2, 1].ToString();
           txtGrid3_3.Text = puzz.puzzle[2, 2].ToString();
           txtGrid3_4.Text = puzz.puzzle[2, 3].ToString();
           txtGrid3_5.Text = puzz.puzzle[2, 4].ToString();
           txtGrid3_6.Text = puzz.puzzle[2, 5].ToString();
           txtGrid3_7.Text = puzz.puzzle[2, 6].ToString();
           txtGrid3_8.Text = puzz.puzzle[2, 7].ToString();
           txtGrid3_9.Text = puzz.puzzle[2, 8].ToString();
           txtGrid4_1.Text = puzz.puzzle[3, 0].ToString();
           txtGrid4_2.Text = puzz.puzzle[3, 1].ToString();
           txtGrid4_3.Text = puzz.puzzle[3, 2].ToString();
           //REST OF LINE 4

           txtGrid5_1.Text = puzz.puzzle[4, 0].ToString();
           //REST OF LINE 5 HERE
           txtGrid6_1.Text = puzz.puzzle[5, 0].ToString();
           //REST OF LINE 6 HERE
           txtGrid7_1.Text = puzz.puzzle[6, 0].ToString();
           //REST OF LINE 7 HERE
           txtGrid8_1.Text = puzz.puzzle[7, 0].ToString();
           //REST OF LINE 8 HERE
           txtGrid9_1.Text = puzz.puzzle[8, 0].ToString();
           //REST OF LINE 9 HERE
       }

       private void btn_SudokuGenerate_Click(object sender, EventArgs e)
       {
           loadPuzzle();
       }

       private void txtGrid4_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_1.Text.Length != 0)
               txtGrid4_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_2.Text.Length != 0)
               txtGrid4_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_3.Text.Length != 0)
               txtGrid4_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_1.Text.Length != 0)
               txtGrid5_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_1.Text.Length != 0)
               txtGrid6_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_1.Text.Length != 0)
               txtGrid7_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_1.Text.Length != 0)
               txtGrid8_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_1.Text.Length != 0)
               txtGrid9_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_1.BackColor = System.Drawing.Color.White;
       }
    

     




    }
}

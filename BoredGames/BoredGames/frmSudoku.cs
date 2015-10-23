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

       private void txtGrid1_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_7.Text.Length != 0)
               txtGrid1_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_8.Text.Length != 0)
               txtGrid1_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid1_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid1_9.Text.Length != 0)
               txtGrid1_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid1_9.BackColor = System.Drawing.Color.White;
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

       private void txtGrid2_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_7.Text.Length != 0)
               txtGrid2_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_8.Text.Length != 0)
               txtGrid2_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid2_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid2_9.Text.Length != 0)
               txtGrid2_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid2_9.BackColor = System.Drawing.Color.White;
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

       private void txtGrid3_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_7.Text.Length != 0)
               txtGrid3_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_8.Text.Length != 0)
               txtGrid3_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid3_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid3_9.Text.Length != 0)
               txtGrid3_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid3_9.BackColor = System.Drawing.Color.White;
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

       private void txtGrid4_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_4.Text.Length != 0)
               txtGrid4_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_5.Text.Length != 0)
               txtGrid4_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_6.Text.Length != 0)
               txtGrid4_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_7.Text.Length != 0)
               txtGrid4_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_8.Text.Length != 0)
               txtGrid4_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid4_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid4_9.Text.Length != 0)
               txtGrid4_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid4_9.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_1.Text.Length != 0)
               txtGrid5_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_1.BackColor = System.Drawing.Color.White;
       }


       private void txtGrid5_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_2.Text.Length != 0)
               txtGrid5_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_3.Text.Length != 0)
               txtGrid5_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_4.Text.Length != 0)
               txtGrid5_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_5.Text.Length != 0)
               txtGrid5_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_6.Text.Length != 0)
               txtGrid5_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_7.Text.Length != 0)
               txtGrid5_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_8.Text.Length != 0)
               txtGrid5_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid5_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid5_9.Text.Length != 0)
               txtGrid5_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid5_9.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_1.Text.Length != 0)
               txtGrid6_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_1.BackColor = System.Drawing.Color.White;
       }


       private void txtGrid6_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_2.Text.Length != 0)
               txtGrid6_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_3.Text.Length != 0)
               txtGrid6_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_4.Text.Length != 0)
               txtGrid6_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_5.Text.Length != 0)
               txtGrid6_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_6.Text.Length != 0)
               txtGrid6_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_7.Text.Length != 0)
               txtGrid6_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_8.Text.Length != 0)
               txtGrid6_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid6_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid6_9.Text.Length != 0)
               txtGrid6_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid6_9.BackColor = System.Drawing.Color.White;
       }


       private void txtGrid7_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_1.Text.Length != 0)
               txtGrid7_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_2.Text.Length != 0)
               txtGrid7_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_3.Text.Length != 0)
               txtGrid7_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_4.Text.Length != 0)
               txtGrid7_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_5.Text.Length != 0)
               txtGrid7_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_6.Text.Length != 0)
               txtGrid7_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_7.Text.Length != 0)
               txtGrid7_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_8.Text.Length != 0)
               txtGrid7_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid7_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid7_9.Text.Length != 0)
               txtGrid7_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid7_9.BackColor = System.Drawing.Color.White;
       }



       private void txtGrid8_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_1.Text.Length != 0)
               txtGrid8_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_2.Text.Length != 0)
               txtGrid8_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_3.Text.Length != 0)
               txtGrid8_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_4.Text.Length != 0)
               txtGrid8_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_5.Text.Length != 0)
               txtGrid8_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_6.Text.Length != 0)
               txtGrid8_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_7.Text.Length != 0)
               txtGrid8_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_8.Text.Length != 0)
               txtGrid8_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid8_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid8_9.Text.Length != 0)
               txtGrid8_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid8_9.BackColor = System.Drawing.Color.White;
       }


       private void txtGrid9_1_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_1.Text.Length != 0)
               txtGrid9_1.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_1.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_2_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_2.Text.Length != 0)
               txtGrid9_2.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_2.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_3_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_3.Text.Length != 0)
               txtGrid9_3.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_3.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_4_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_4.Text.Length != 0)
               txtGrid9_4.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_4.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_5_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_5.Text.Length != 0)
               txtGrid9_5.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_5.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_6_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_6.Text.Length != 0)
               txtGrid9_6.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_6.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_7_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_7.Text.Length != 0)
               txtGrid9_7.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_7.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_8_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_8.Text.Length != 0)
               txtGrid9_8.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_8.BackColor = System.Drawing.Color.White;
       }

       private void txtGrid9_9_TextChanged(object sender, EventArgs e)
       {
           if (txtGrid9_9.Text.Length != 0)
               txtGrid9_9.BackColor = System.Drawing.Color.DimGray;
           else txtGrid9_9.BackColor = System.Drawing.Color.White;
       }


       private void btn_SudokuGenerate_Click(object sender, EventArgs e)
       {
           loadPuzzle();
       }

       private void loadPuzzle()
       {
           SudokuPuzzleMaker puzz = new SudokuPuzzleMaker();

           puzz.generate();

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
           txtGrid2_9.Text = puzz.puzzle[1, 8].ToString();
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
           txtGrid4_4.Text = puzz.puzzle[3, 3].ToString();
           txtGrid4_5.Text = puzz.puzzle[3, 4].ToString();
           txtGrid4_6.Text = puzz.puzzle[3, 5].ToString();
           txtGrid4_7.Text = puzz.puzzle[3, 6].ToString();
           txtGrid4_8.Text = puzz.puzzle[3, 7].ToString();
           txtGrid4_9.Text = puzz.puzzle[3, 8].ToString();
           txtGrid5_1.Text = puzz.puzzle[4, 0].ToString();
           txtGrid5_2.Text = puzz.puzzle[4, 1].ToString();
           txtGrid5_3.Text = puzz.puzzle[4, 2].ToString();
           txtGrid5_4.Text = puzz.puzzle[4, 3].ToString();
           txtGrid5_5.Text = puzz.puzzle[4, 4].ToString();
           txtGrid5_6.Text = puzz.puzzle[4, 5].ToString();
           txtGrid5_7.Text = puzz.puzzle[4, 6].ToString();
           txtGrid5_8.Text = puzz.puzzle[4, 7].ToString();
           txtGrid5_9.Text = puzz.puzzle[4, 8].ToString();
           txtGrid6_1.Text = puzz.puzzle[5, 0].ToString();
           txtGrid6_2.Text = puzz.puzzle[5, 1].ToString();
           txtGrid6_3.Text = puzz.puzzle[5, 2].ToString();
           txtGrid6_4.Text = puzz.puzzle[5, 3].ToString();
           txtGrid6_5.Text = puzz.puzzle[5, 4].ToString();
           txtGrid6_6.Text = puzz.puzzle[5, 5].ToString();
           txtGrid6_7.Text = puzz.puzzle[5, 6].ToString();
           txtGrid6_8.Text = puzz.puzzle[5, 7].ToString();
           txtGrid6_9.Text = puzz.puzzle[5, 8].ToString();
           txtGrid7_1.Text = puzz.puzzle[6, 0].ToString();
           txtGrid7_2.Text = puzz.puzzle[6, 1].ToString();
           txtGrid7_3.Text = puzz.puzzle[6, 2].ToString();
           txtGrid7_4.Text = puzz.puzzle[6, 3].ToString();
           txtGrid7_5.Text = puzz.puzzle[6, 4].ToString();
           txtGrid7_6.Text = puzz.puzzle[6, 5].ToString();
           txtGrid7_7.Text = puzz.puzzle[6, 6].ToString();
           txtGrid7_8.Text = puzz.puzzle[6, 7].ToString();
           txtGrid7_9.Text = puzz.puzzle[6, 8].ToString();
           txtGrid8_1.Text = puzz.puzzle[7, 0].ToString();
           txtGrid8_2.Text = puzz.puzzle[7, 1].ToString();
           txtGrid8_3.Text = puzz.puzzle[7, 2].ToString();
           txtGrid8_4.Text = puzz.puzzle[7, 3].ToString();
           txtGrid8_5.Text = puzz.puzzle[7, 4].ToString();
           txtGrid8_6.Text = puzz.puzzle[7, 5].ToString();
           txtGrid8_7.Text = puzz.puzzle[7, 6].ToString();
           txtGrid8_8.Text = puzz.puzzle[7, 7].ToString();
           txtGrid8_9.Text = puzz.puzzle[7, 8].ToString();
           txtGrid9_1.Text = puzz.puzzle[8, 0].ToString();
           txtGrid9_2.Text = puzz.puzzle[8, 1].ToString();
           txtGrid9_3.Text = puzz.puzzle[8, 2].ToString();
           txtGrid9_4.Text = puzz.puzzle[8, 3].ToString();
           txtGrid9_5.Text = puzz.puzzle[8, 4].ToString();
           txtGrid9_6.Text = puzz.puzzle[8, 5].ToString();
           txtGrid9_7.Text = puzz.puzzle[8, 6].ToString();
           txtGrid9_8.Text = puzz.puzzle[8, 7].ToString();
           txtGrid9_9.Text = puzz.puzzle[8, 8].ToString();
       }

       

       

       

      

      

       

       

       

       
     




    }
}

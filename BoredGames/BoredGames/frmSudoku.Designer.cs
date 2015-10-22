namespace BoredGames
{
    partial class frmSudoku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSudoku));
            this.txtGrid1_1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGrid7_2 = new System.Windows.Forms.TextBox();
            this.txtGrid5_5 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGrid1_1
            // 
            this.txtGrid1_1.BackColor = System.Drawing.Color.White;
            this.txtGrid1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_1.Location = new System.Drawing.Point(3, 3);
            this.txtGrid1_1.MaxLength = 1;
            this.txtGrid1_1.Name = "txtGrid1_1";
            this.txtGrid1_1.Size = new System.Drawing.Size(70, 44);
            this.txtGrid1_1.TabIndex = 0;
            this.txtGrid1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_1.TextChanged += new System.EventHandler(this.txtGrid1_1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtGrid7_2);
            this.panel1.Controls.Add(this.txtGrid5_5);
            this.panel1.Controls.Add(this.txtGrid1_1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(136, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 443);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtGrid7_2
            // 
            this.txtGrid7_2.BackColor = System.Drawing.Color.White;
            this.txtGrid7_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid7_2.Location = new System.Drawing.Point(474, 49);
            this.txtGrid7_2.MaxLength = 1;
            this.txtGrid7_2.Name = "txtGrid7_2";
            this.txtGrid7_2.Size = new System.Drawing.Size(70, 44);
            this.txtGrid7_2.TabIndex = 2;
            this.txtGrid7_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrid5_5
            // 
            this.txtGrid5_5.BackColor = System.Drawing.Color.White;
            this.txtGrid5_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid5_5.Location = new System.Drawing.Point(313, 199);
            this.txtGrid5_5.MaxLength = 1;
            this.txtGrid5_5.Name = "txtGrid5_5";
            this.txtGrid5_5.Size = new System.Drawing.Size(70, 44);
            this.txtGrid5_5.TabIndex = 1;
            this.txtGrid5_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid5_5.TextChanged += new System.EventHandler(this.txtGrid5_5_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Buxton Sketch", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(732, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 54);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "QUIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 640);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSudoku";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.frmSudoku_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrid1_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGrid5_5;
        private System.Windows.Forms.TextBox txtGrid7_2;
        private System.Windows.Forms.Button btnExit;


    }
}
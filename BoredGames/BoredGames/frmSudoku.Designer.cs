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
            this.txtGrid3_3 = new System.Windows.Forms.TextBox();
            this.txtGrid3_2 = new System.Windows.Forms.TextBox();
            this.txtGrid3_1 = new System.Windows.Forms.TextBox();
            this.txtGrid2_2 = new System.Windows.Forms.TextBox();
            this.txtGrid2_1 = new System.Windows.Forms.TextBox();
            this.txtGrid1_3 = new System.Windows.Forms.TextBox();
            this.txtGrid1_2 = new System.Windows.Forms.TextBox();
            this.txtGrid7_2 = new System.Windows.Forms.TextBox();
            this.txtGrid5_5 = new System.Windows.Forms.TextBox();
            this.txtGrid2_3 = new System.Windows.Forms.TextBox();
            this.txtGrid1_4 = new System.Windows.Forms.TextBox();
            this.txtGrid2_4 = new System.Windows.Forms.TextBox();
            this.txtGrid3_4 = new System.Windows.Forms.TextBox();
            this.txtGrid1_5 = new System.Windows.Forms.TextBox();
            this.txtGrid2_5 = new System.Windows.Forms.TextBox();
            this.txtGrid3_5 = new System.Windows.Forms.TextBox();
            this.txtGrid1_6 = new System.Windows.Forms.TextBox();
            this.txtGrid2_6 = new System.Windows.Forms.TextBox();
            this.txtGrid3_6 = new System.Windows.Forms.TextBox();
            this.txtGrid1_7 = new System.Windows.Forms.TextBox();
            this.txtGrid2_7 = new System.Windows.Forms.TextBox();
            this.txtGrid3_7 = new System.Windows.Forms.TextBox();
            this.txtGrid1_8 = new System.Windows.Forms.TextBox();
            this.txtGrid2_8 = new System.Windows.Forms.TextBox();
            this.txtGrid3_8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtGrid1_9 = new System.Windows.Forms.TextBox();
            this.txtGrid2_9 = new System.Windows.Forms.TextBox();
            this.txtGrid3_9 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGrid1_1
            // 
            this.txtGrid1_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGrid1_1.BackColor = System.Drawing.Color.White;
            this.txtGrid1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_1.Location = new System.Drawing.Point(3, 1);
            this.txtGrid1_1.MaxLength = 1;
            this.txtGrid1_1.Name = "txtGrid1_1";
            this.txtGrid1_1.Size = new System.Drawing.Size(71, 45);
            this.txtGrid1_1.TabIndex = 0;
            this.txtGrid1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_1.TextChanged += new System.EventHandler(this.txtGrid1_1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtGrid3_9);
            this.panel1.Controls.Add(this.txtGrid2_9);
            this.panel1.Controls.Add(this.txtGrid1_9);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.txtGrid3_8);
            this.panel1.Controls.Add(this.txtGrid2_8);
            this.panel1.Controls.Add(this.txtGrid1_8);
            this.panel1.Controls.Add(this.txtGrid3_7);
            this.panel1.Controls.Add(this.txtGrid2_7);
            this.panel1.Controls.Add(this.txtGrid1_7);
            this.panel1.Controls.Add(this.txtGrid3_6);
            this.panel1.Controls.Add(this.txtGrid2_6);
            this.panel1.Controls.Add(this.txtGrid1_6);
            this.panel1.Controls.Add(this.txtGrid3_5);
            this.panel1.Controls.Add(this.txtGrid2_5);
            this.panel1.Controls.Add(this.txtGrid1_5);
            this.panel1.Controls.Add(this.txtGrid3_4);
            this.panel1.Controls.Add(this.txtGrid2_4);
            this.panel1.Controls.Add(this.txtGrid1_4);
            this.panel1.Controls.Add(this.txtGrid2_3);
            this.panel1.Controls.Add(this.txtGrid3_3);
            this.panel1.Controls.Add(this.txtGrid3_2);
            this.panel1.Controls.Add(this.txtGrid3_1);
            this.panel1.Controls.Add(this.txtGrid2_2);
            this.panel1.Controls.Add(this.txtGrid2_1);
            this.panel1.Controls.Add(this.txtGrid1_3);
            this.panel1.Controls.Add(this.txtGrid1_2);
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
            // txtGrid3_3
            // 
            this.txtGrid3_3.BackColor = System.Drawing.Color.White;
            this.txtGrid3_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_3.Location = new System.Drawing.Point(149, 94);
            this.txtGrid3_3.MaxLength = 1;
            this.txtGrid3_3.Name = "txtGrid3_3";
            this.txtGrid3_3.Size = new System.Drawing.Size(72, 45);
            this.txtGrid3_3.TabIndex = 10;
            this.txtGrid3_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_3.TextChanged += new System.EventHandler(this.txtGrid3_3_TextChanged);
            // 
            // txtGrid3_2
            // 
            this.txtGrid3_2.BackColor = System.Drawing.Color.White;
            this.txtGrid3_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_2.Location = new System.Drawing.Point(75, 94);
            this.txtGrid3_2.MaxLength = 1;
            this.txtGrid3_2.Name = "txtGrid3_2";
            this.txtGrid3_2.Size = new System.Drawing.Size(72, 45);
            this.txtGrid3_2.TabIndex = 9;
            this.txtGrid3_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_2.TextChanged += new System.EventHandler(this.txtGrid3_2_TextChanged);
            // 
            // txtGrid3_1
            // 
            this.txtGrid3_1.BackColor = System.Drawing.Color.White;
            this.txtGrid3_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_1.Location = new System.Drawing.Point(3, 94);
            this.txtGrid3_1.MaxLength = 1;
            this.txtGrid3_1.Name = "txtGrid3_1";
            this.txtGrid3_1.Size = new System.Drawing.Size(71, 45);
            this.txtGrid3_1.TabIndex = 8;
            this.txtGrid3_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_1.TextChanged += new System.EventHandler(this.txtGrid3_1_TextChanged);
            // 
            // txtGrid2_2
            // 
            this.txtGrid2_2.BackColor = System.Drawing.Color.White;
            this.txtGrid2_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_2.Location = new System.Drawing.Point(75, 47);
            this.txtGrid2_2.MaxLength = 1;
            this.txtGrid2_2.Name = "txtGrid2_2";
            this.txtGrid2_2.Size = new System.Drawing.Size(72, 45);
            this.txtGrid2_2.TabIndex = 6;
            this.txtGrid2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_2.TextChanged += new System.EventHandler(this.txtGrid2_2_TextChanged);
            // 
            // txtGrid2_1
            // 
            this.txtGrid2_1.BackColor = System.Drawing.Color.White;
            this.txtGrid2_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_1.Location = new System.Drawing.Point(3, 47);
            this.txtGrid2_1.MaxLength = 1;
            this.txtGrid2_1.Name = "txtGrid2_1";
            this.txtGrid2_1.Size = new System.Drawing.Size(71, 45);
            this.txtGrid2_1.TabIndex = 5;
            this.txtGrid2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_1.TextChanged += new System.EventHandler(this.txtGrid2_1_TextChanged);
            // 
            // txtGrid1_3
            // 
            this.txtGrid1_3.BackColor = System.Drawing.Color.White;
            this.txtGrid1_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_3.Location = new System.Drawing.Point(149, 1);
            this.txtGrid1_3.MaxLength = 1;
            this.txtGrid1_3.Name = "txtGrid1_3";
            this.txtGrid1_3.Size = new System.Drawing.Size(72, 45);
            this.txtGrid1_3.TabIndex = 4;
            this.txtGrid1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_3.TextChanged += new System.EventHandler(this.txtGrid1_3_TextChanged);
            // 
            // txtGrid1_2
            // 
            this.txtGrid1_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGrid1_2.BackColor = System.Drawing.Color.White;
            this.txtGrid1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_2.Location = new System.Drawing.Point(75, 1);
            this.txtGrid1_2.MaxLength = 1;
            this.txtGrid1_2.Name = "txtGrid1_2";
            this.txtGrid1_2.Size = new System.Drawing.Size(72, 45);
            this.txtGrid1_2.TabIndex = 3;
            this.txtGrid1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_2.TextChanged += new System.EventHandler(this.txtGrid1_2_TextChanged);
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
            // 
            // txtGrid2_3
            // 
            this.txtGrid2_3.BackColor = System.Drawing.Color.White;
            this.txtGrid2_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_3.Location = new System.Drawing.Point(149, 47);
            this.txtGrid2_3.MaxLength = 1;
            this.txtGrid2_3.Name = "txtGrid2_3";
            this.txtGrid2_3.Size = new System.Drawing.Size(72, 45);
            this.txtGrid2_3.TabIndex = 11;
            this.txtGrid2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_3.TextChanged += new System.EventHandler(this.txtGrid2_3_TextChanged);
            // 
            // txtGrid1_4
            // 
            this.txtGrid1_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid1_4.BackColor = System.Drawing.Color.White;
            this.txtGrid1_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_4.Location = new System.Drawing.Point(236, 1);
            this.txtGrid1_4.MaxLength = 1;
            this.txtGrid1_4.Name = "txtGrid1_4";
            this.txtGrid1_4.Size = new System.Drawing.Size(73, 45);
            this.txtGrid1_4.TabIndex = 12;
            this.txtGrid1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_4.TextChanged += new System.EventHandler(this.txtGrid1_4_TextChanged);
            // 
            // txtGrid2_4
            // 
            this.txtGrid2_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid2_4.BackColor = System.Drawing.Color.White;
            this.txtGrid2_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_4.Location = new System.Drawing.Point(236, 47);
            this.txtGrid2_4.MaxLength = 1;
            this.txtGrid2_4.Name = "txtGrid2_4";
            this.txtGrid2_4.Size = new System.Drawing.Size(73, 45);
            this.txtGrid2_4.TabIndex = 13;
            this.txtGrid2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_4.TextChanged += new System.EventHandler(this.txtGrid2_4_TextChanged);
            // 
            // txtGrid3_4
            // 
            this.txtGrid3_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid3_4.BackColor = System.Drawing.Color.White;
            this.txtGrid3_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_4.Location = new System.Drawing.Point(236, 94);
            this.txtGrid3_4.MaxLength = 1;
            this.txtGrid3_4.Name = "txtGrid3_4";
            this.txtGrid3_4.Size = new System.Drawing.Size(73, 45);
            this.txtGrid3_4.TabIndex = 14;
            this.txtGrid3_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_4.TextChanged += new System.EventHandler(this.txtGrid3_4_TextChanged);
            // 
            // txtGrid1_5
            // 
            this.txtGrid1_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid1_5.BackColor = System.Drawing.Color.White;
            this.txtGrid1_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_5.Location = new System.Drawing.Point(311, 1);
            this.txtGrid1_5.MaxLength = 1;
            this.txtGrid1_5.Name = "txtGrid1_5";
            this.txtGrid1_5.Size = new System.Drawing.Size(72, 45);
            this.txtGrid1_5.TabIndex = 15;
            this.txtGrid1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_5.TextChanged += new System.EventHandler(this.txtGrid1_5_TextChanged);
            // 
            // txtGrid2_5
            // 
            this.txtGrid2_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid2_5.BackColor = System.Drawing.Color.White;
            this.txtGrid2_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_5.Location = new System.Drawing.Point(311, 47);
            this.txtGrid2_5.MaxLength = 1;
            this.txtGrid2_5.Name = "txtGrid2_5";
            this.txtGrid2_5.Size = new System.Drawing.Size(72, 45);
            this.txtGrid2_5.TabIndex = 16;
            this.txtGrid2_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_5.TextChanged += new System.EventHandler(this.txtGrid2_5_TextChanged);
            // 
            // txtGrid3_5
            // 
            this.txtGrid3_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid3_5.BackColor = System.Drawing.Color.White;
            this.txtGrid3_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_5.Location = new System.Drawing.Point(311, 94);
            this.txtGrid3_5.MaxLength = 1;
            this.txtGrid3_5.Name = "txtGrid3_5";
            this.txtGrid3_5.Size = new System.Drawing.Size(72, 45);
            this.txtGrid3_5.TabIndex = 17;
            this.txtGrid3_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_5.TextChanged += new System.EventHandler(this.txtGrid3_5_TextChanged);
            // 
            // txtGrid1_6
            // 
            this.txtGrid1_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid1_6.BackColor = System.Drawing.Color.White;
            this.txtGrid1_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_6.Location = new System.Drawing.Point(385, 1);
            this.txtGrid1_6.MaxLength = 1;
            this.txtGrid1_6.Name = "txtGrid1_6";
            this.txtGrid1_6.Size = new System.Drawing.Size(72, 45);
            this.txtGrid1_6.TabIndex = 18;
            this.txtGrid1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_6.TextChanged += new System.EventHandler(this.txtGrid1_6_TextChanged);
            // 
            // txtGrid2_6
            // 
            this.txtGrid2_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid2_6.BackColor = System.Drawing.Color.White;
            this.txtGrid2_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_6.Location = new System.Drawing.Point(385, 47);
            this.txtGrid2_6.MaxLength = 1;
            this.txtGrid2_6.Name = "txtGrid2_6";
            this.txtGrid2_6.Size = new System.Drawing.Size(72, 45);
            this.txtGrid2_6.TabIndex = 19;
            this.txtGrid2_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_6.TextChanged += new System.EventHandler(this.txtGrid2_6_TextChanged);
            // 
            // txtGrid3_6
            // 
            this.txtGrid3_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid3_6.BackColor = System.Drawing.Color.White;
            this.txtGrid3_6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_6.Location = new System.Drawing.Point(385, 94);
            this.txtGrid3_6.MaxLength = 1;
            this.txtGrid3_6.Name = "txtGrid3_6";
            this.txtGrid3_6.Size = new System.Drawing.Size(72, 45);
            this.txtGrid3_6.TabIndex = 20;
            this.txtGrid3_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_6.TextChanged += new System.EventHandler(this.txtGrid3_6_TextChanged);
            // 
            // txtGrid1_7
            // 
            this.txtGrid1_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid1_7.BackColor = System.Drawing.Color.White;
            this.txtGrid1_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_7.Location = new System.Drawing.Point(471, 1);
            this.txtGrid1_7.MaxLength = 1;
            this.txtGrid1_7.Name = "txtGrid1_7";
            this.txtGrid1_7.Size = new System.Drawing.Size(74, 45);
            this.txtGrid1_7.TabIndex = 21;
            this.txtGrid1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_7.TextChanged += new System.EventHandler(this.txtGrid1_7_TextChanged);
            // 
            // txtGrid2_7
            // 
            this.txtGrid2_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid2_7.BackColor = System.Drawing.Color.White;
            this.txtGrid2_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_7.Location = new System.Drawing.Point(471, 47);
            this.txtGrid2_7.MaxLength = 1;
            this.txtGrid2_7.Name = "txtGrid2_7";
            this.txtGrid2_7.Size = new System.Drawing.Size(74, 45);
            this.txtGrid2_7.TabIndex = 22;
            this.txtGrid2_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_7.TextChanged += new System.EventHandler(this.txtGrid2_7_TextChanged);
            // 
            // txtGrid3_7
            // 
            this.txtGrid3_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid3_7.BackColor = System.Drawing.Color.White;
            this.txtGrid3_7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_7.Location = new System.Drawing.Point(471, 94);
            this.txtGrid3_7.MaxLength = 1;
            this.txtGrid3_7.Name = "txtGrid3_7";
            this.txtGrid3_7.Size = new System.Drawing.Size(74, 45);
            this.txtGrid3_7.TabIndex = 23;
            this.txtGrid3_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_7.TextChanged += new System.EventHandler(this.txtGrid3_7_TextChanged);
            // 
            // txtGrid1_8
            // 
            this.txtGrid1_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid1_8.BackColor = System.Drawing.Color.White;
            this.txtGrid1_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_8.Location = new System.Drawing.Point(547, 1);
            this.txtGrid1_8.MaxLength = 1;
            this.txtGrid1_8.Name = "txtGrid1_8";
            this.txtGrid1_8.Size = new System.Drawing.Size(72, 45);
            this.txtGrid1_8.TabIndex = 24;
            this.txtGrid1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_8.TextChanged += new System.EventHandler(this.txtGrid1_8_TextChanged);
            // 
            // txtGrid2_8
            // 
            this.txtGrid2_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid2_8.BackColor = System.Drawing.Color.White;
            this.txtGrid2_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_8.Location = new System.Drawing.Point(547, 47);
            this.txtGrid2_8.MaxLength = 1;
            this.txtGrid2_8.Name = "txtGrid2_8";
            this.txtGrid2_8.Size = new System.Drawing.Size(72, 45);
            this.txtGrid2_8.TabIndex = 25;
            this.txtGrid2_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_8.TextChanged += new System.EventHandler(this.txtGrid2_8_TextChanged);
            // 
            // txtGrid3_8
            // 
            this.txtGrid3_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid3_8.BackColor = System.Drawing.Color.White;
            this.txtGrid3_8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_8.Location = new System.Drawing.Point(547, 94);
            this.txtGrid3_8.MaxLength = 1;
            this.txtGrid3_8.Name = "txtGrid3_8";
            this.txtGrid3_8.Size = new System.Drawing.Size(72, 45);
            this.txtGrid3_8.TabIndex = 26;
            this.txtGrid3_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_8.TextChanged += new System.EventHandler(this.txtGrid3_8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(312, 197);
            this.textBox7.MaxLength = 1;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(73, 45);
            this.textBox7.TabIndex = 27;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrid1_9
            // 
            this.txtGrid1_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid1_9.BackColor = System.Drawing.Color.White;
            this.txtGrid1_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid1_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid1_9.Location = new System.Drawing.Point(621, 1);
            this.txtGrid1_9.MaxLength = 1;
            this.txtGrid1_9.Name = "txtGrid1_9";
            this.txtGrid1_9.Size = new System.Drawing.Size(74, 45);
            this.txtGrid1_9.TabIndex = 27;
            this.txtGrid1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid1_9.TextChanged += new System.EventHandler(this.txtGrid1_9_TextChanged);
            // 
            // txtGrid2_9
            // 
            this.txtGrid2_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid2_9.BackColor = System.Drawing.Color.White;
            this.txtGrid2_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid2_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid2_9.Location = new System.Drawing.Point(621, 47);
            this.txtGrid2_9.MaxLength = 1;
            this.txtGrid2_9.Name = "txtGrid2_9";
            this.txtGrid2_9.Size = new System.Drawing.Size(74, 45);
            this.txtGrid2_9.TabIndex = 28;
            this.txtGrid2_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid2_9.TextChanged += new System.EventHandler(this.txtGrid2_9_TextChanged);
            // 
            // txtGrid3_9
            // 
            this.txtGrid3_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrid3_9.BackColor = System.Drawing.Color.White;
            this.txtGrid3_9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrid3_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrid3_9.Location = new System.Drawing.Point(621, 94);
            this.txtGrid3_9.MaxLength = 1;
            this.txtGrid3_9.Name = "txtGrid3_9";
            this.txtGrid3_9.Size = new System.Drawing.Size(74, 45);
            this.txtGrid3_9.TabIndex = 29;
            this.txtGrid3_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGrid3_9.TextChanged += new System.EventHandler(this.txtGrid3_9_TextChanged);
            // 
            // frmSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 640);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtGrid2_1;
        private System.Windows.Forms.TextBox txtGrid1_3;
        private System.Windows.Forms.TextBox txtGrid1_2;
        private System.Windows.Forms.TextBox txtGrid3_3;
        private System.Windows.Forms.TextBox txtGrid3_2;
        private System.Windows.Forms.TextBox txtGrid3_1;
        private System.Windows.Forms.TextBox txtGrid2_2;
        private System.Windows.Forms.TextBox txtGrid2_3;
        private System.Windows.Forms.TextBox txtGrid3_6;
        private System.Windows.Forms.TextBox txtGrid2_6;
        private System.Windows.Forms.TextBox txtGrid1_6;
        private System.Windows.Forms.TextBox txtGrid3_5;
        private System.Windows.Forms.TextBox txtGrid2_5;
        private System.Windows.Forms.TextBox txtGrid1_5;
        private System.Windows.Forms.TextBox txtGrid3_4;
        private System.Windows.Forms.TextBox txtGrid2_4;
        private System.Windows.Forms.TextBox txtGrid1_4;
        private System.Windows.Forms.TextBox txtGrid2_7;
        private System.Windows.Forms.TextBox txtGrid1_7;
        private System.Windows.Forms.TextBox txtGrid3_9;
        private System.Windows.Forms.TextBox txtGrid2_9;
        private System.Windows.Forms.TextBox txtGrid1_9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtGrid3_8;
        private System.Windows.Forms.TextBox txtGrid2_8;
        private System.Windows.Forms.TextBox txtGrid1_8;
        private System.Windows.Forms.TextBox txtGrid3_7;


    }
}
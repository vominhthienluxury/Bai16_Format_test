namespace Bai16_Format_test
{
    partial class Formtest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.redbtn = new System.Windows.Forms.RadioButton();
            this.bluebtn = new System.Windows.Forms.RadioButton();
            this.greenbtn = new System.Windows.Forms.RadioButton();
            this.blackbtn = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lbllaptrinh = new System.Windows.Forms.Label();
            this.lbllaptrinhhien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(148, 27);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(206, 20);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.TextChanged += new System.EventHandler(this.txtnhaten_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.blackbtn);
            this.groupBox1.Controls.Add(this.greenbtn);
            this.groupBox1.Controls.Add(this.bluebtn);
            this.groupBox1.Controls.Add(this.redbtn);
            this.groupBox1.Location = new System.Drawing.Point(42, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(277, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "font";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(402, 348);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // redbtn
            // 
            this.redbtn.AutoSize = true;
            this.redbtn.Location = new System.Drawing.Point(17, 45);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(45, 17);
            this.redbtn.TabIndex = 0;
            this.redbtn.TabStop = true;
            this.redbtn.Text = "Red";
            this.redbtn.UseVisualStyleBackColor = true;
            this.redbtn.CheckedChanged += new System.EventHandler(this.redbtn_CheckedChanged);
            // 
            // bluebtn
            // 
            this.bluebtn.AutoSize = true;
            this.bluebtn.Location = new System.Drawing.Point(17, 69);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(46, 17);
            this.bluebtn.TabIndex = 1;
            this.bluebtn.TabStop = true;
            this.bluebtn.Text = "Blue";
            this.bluebtn.UseVisualStyleBackColor = true;
            this.bluebtn.CheckedChanged += new System.EventHandler(this.bluebtn_CheckedChanged);
            // 
            // greenbtn
            // 
            this.greenbtn.AutoSize = true;
            this.greenbtn.Location = new System.Drawing.Point(17, 93);
            this.greenbtn.Name = "greenbtn";
            this.greenbtn.Size = new System.Drawing.Size(54, 17);
            this.greenbtn.TabIndex = 2;
            this.greenbtn.TabStop = true;
            this.greenbtn.Text = "Green";
            this.greenbtn.UseVisualStyleBackColor = true;
            this.greenbtn.CheckedChanged += new System.EventHandler(this.greenbtn_CheckedChanged);
            // 
            // blackbtn
            // 
            this.blackbtn.AutoSize = true;
            this.blackbtn.Location = new System.Drawing.Point(17, 117);
            this.blackbtn.Name = "blackbtn";
            this.blackbtn.Size = new System.Drawing.Size(52, 17);
            this.blackbtn.TabIndex = 3;
            this.blackbtn.TabStop = true;
            this.blackbtn.Text = "Black";
            this.blackbtn.UseVisualStyleBackColor = true;
            this.blackbtn.CheckedChanged += new System.EventHandler(this.blackbtn_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(21, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "In đậm ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("San Francisco Text Light Italic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(21, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "IN nghiên";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(21, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Ngạch chân";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.AutoSize = true;
            this.lbllaptrinh.Location = new System.Drawing.Point(77, 348);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(68, 13);
            this.lbllaptrinh.TabIndex = 5;
            this.lbllaptrinh.Text = "Lập trình bởi:";
            // 
            // lbllaptrinhhien
            // 
            this.lbllaptrinhhien.AutoSize = true;
            this.lbllaptrinhhien.Location = new System.Drawing.Point(148, 347);
            this.lbllaptrinhhien.Name = "lbllaptrinhhien";
            this.lbllaptrinhhien.Size = new System.Drawing.Size(35, 13);
            this.lbllaptrinhhien.TabIndex = 6;
            this.lbllaptrinhhien.Text = "label2";
            // 
            // Formtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllaptrinhhien);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Name = "Formtest";
            this.Text = "Formtest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton blackbtn;
        private System.Windows.Forms.RadioButton greenbtn;
        private System.Windows.Forms.RadioButton bluebtn;
        private System.Windows.Forms.RadioButton redbtn;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label lbllaptrinh;
        private System.Windows.Forms.Label lbllaptrinhhien;
    }
}
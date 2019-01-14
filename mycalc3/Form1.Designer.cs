namespace mycalc3
{
    partial class Form1
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
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btnonoff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtdisplay.Location = new System.Drawing.Point(3, 12);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(264, 27);
            this.txtdisplay.TabIndex = 0;
            this.txtdisplay.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            // 
            // btnonoff
            // 
            this.btnonoff.Location = new System.Drawing.Point(3, 45);
            this.btnonoff.Name = "btnonoff";
            this.btnonoff.Size = new System.Drawing.Size(75, 34);
            this.btnonoff.TabIndex = 1;
            this.btnonoff.Text = "Off";
            this.btnonoff.UseVisualStyleBackColor = true;
            this.btnonoff.Click += new System.EventHandler(this.btnonoff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btnmul);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btnsub);
            this.panel1.Controls.Add(this.btndiv);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 295);
            this.panel1.TabIndex = 2;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(136, 9);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(120, 48);
            this.button23.TabIndex = 20;
            this.button23.Text = "Clear";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(10, 9);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(120, 48);
            this.button22.TabIndex = 19;
            this.button22.Text = "<-------";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(136, 235);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 48);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numbers);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(199, 235);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(57, 48);
            this.btnequal.TabIndex = 17;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(73, 235);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 48);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numbers);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(10, 235);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 48);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(136, 181);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 48);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numbers);
            // 
            // btnpoint
            // 
            this.btnpoint.Location = new System.Drawing.Point(199, 181);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(57, 48);
            this.btnpoint.TabIndex = 13;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(73, 181);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 48);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(10, 181);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 48);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numbers);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(136, 124);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 48);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numbers);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(199, 124);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(57, 48);
            this.btnmul.TabIndex = 9;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.Operators);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(73, 124);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 48);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numbers);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(10, 124);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 48);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numbers);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(136, 63);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(57, 48);
            this.btnsub.TabIndex = 6;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.Operators);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(199, 63);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(57, 48);
            this.btndiv.TabIndex = 5;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.Operators);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 48);
            this.button5.TabIndex = 6;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(73, 63);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(57, 48);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Operators);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(10, 63);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 48);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numbers);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnonoff);
            this.Controls.Add(this.txtdisplay);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btnonoff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}


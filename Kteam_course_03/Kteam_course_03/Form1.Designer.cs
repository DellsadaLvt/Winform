namespace Kteam_course_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.btnValue = new System.Windows.Forms.Button();
            this.lbValue = new System.Windows.Forms.Label();
            this.ckbKter = new System.Windows.Forms.CheckBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lbNameKter = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "HowKteam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(350, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click here to add button";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(178, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "dell sada";
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(13, 212);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(100, 22);
            this.txbValue.TabIndex = 0;
            this.txbValue.TextChanged += new System.EventHandler(this.txbValue_TextChanged);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(119, 212);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(75, 23);
            this.btnValue.TabIndex = 5;
            this.btnValue.Text = "Enter";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(12, 250);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(46, 17);
            this.lbValue.TabIndex = 6;
            this.lbValue.Text = "label2";
            // 
            // ckbKter
            // 
            this.ckbKter.AutoSize = true;
            this.ckbKter.Checked = true;
            this.ckbKter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbKter.Location = new System.Drawing.Point(294, 250);
            this.ckbKter.Name = "ckbKter";
            this.ckbKter.Size = new System.Drawing.Size(117, 21);
            this.ckbKter.TabIndex = 7;
            this.ckbKter.Text = "Are you Kter?";
            this.ckbKter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ckbKter.ThreeState = true;
            this.ckbKter.UseVisualStyleBackColor = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(294, 214);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 22);
            this.txbName.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(294, 277);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lbNameKter
            // 
            this.lbNameKter.AutoSize = true;
            this.lbNameKter.Location = new System.Drawing.Point(291, 325);
            this.lbNameKter.Name = "lbNameKter";
            this.lbNameKter.Size = new System.Drawing.Size(46, 17);
            this.lbNameKter.TabIndex = 6;
            this.lbNameKter.Text = "label2";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(291, 181);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 17);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnValue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbKter);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbNameKter);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.CheckBox ckbKter;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lbNameKter;
        private System.Windows.Forms.Label lbName;
    }
}


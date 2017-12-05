namespace CustomGroupBoxSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customGroupBox1 = new CustomGroupBoxSample.CustomGroupBox();
            this.customGroupBox2 = new CustomGroupBoxSample.CustomGroupBox();
            this.customGroupBox3 = new CustomGroupBoxSample.CustomGroupBox();
            this.customGroupBox4 = new CustomGroupBoxSample.CustomGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.customGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customGroupBox1.Location = new System.Drawing.Point(22, 12);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(200, 100);
            this.customGroupBox1.TabIndex = 0;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            this.customGroupBox1.TextColor = System.Drawing.Color.Red;
            // 
            // customGroupBox2
            // 
            this.customGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.customGroupBox2.Controls.Add(this.label2);
            this.customGroupBox2.Controls.Add(this.label1);
            this.customGroupBox2.Location = new System.Drawing.Point(22, 118);
            this.customGroupBox2.Name = "customGroupBox2";
            this.customGroupBox2.Size = new System.Drawing.Size(200, 100);
            this.customGroupBox2.TabIndex = 0;
            this.customGroupBox2.TabStop = false;
            this.customGroupBox2.Text = "customGroupBox1";
            this.customGroupBox2.TextColor = System.Drawing.Color.Blue;
            // 
            // customGroupBox3
            // 
            this.customGroupBox3.BackColor = System.Drawing.Color.Silver;
            this.customGroupBox3.BorderColor = System.Drawing.Color.Blue;
            this.customGroupBox3.Location = new System.Drawing.Point(238, 12);
            this.customGroupBox3.Name = "customGroupBox3";
            this.customGroupBox3.Size = new System.Drawing.Size(200, 100);
            this.customGroupBox3.TabIndex = 0;
            this.customGroupBox3.TabStop = false;
            this.customGroupBox3.Text = "customGroupBox1";
            // 
            // customGroupBox4
            // 
            this.customGroupBox4.Location = new System.Drawing.Point(238, 118);
            this.customGroupBox4.Name = "customGroupBox4";
            this.customGroupBox4.Size = new System.Drawing.Size(200, 100);
            this.customGroupBox4.TabIndex = 0;
            this.customGroupBox4.TabStop = false;
            this.customGroupBox4.Text = "customGroupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 238);
            this.Controls.Add(this.customGroupBox4);
            this.Controls.Add(this.customGroupBox3);
            this.Controls.Add(this.customGroupBox2);
            this.Controls.Add(this.customGroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.customGroupBox2.ResumeLayout(false);
            this.customGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGroupBoxSample.CustomGroupBox customGroupBox1;
        private CustomGroupBoxSample.CustomGroupBox customGroupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomGroupBoxSample.CustomGroupBox customGroupBox3;
        private CustomGroupBoxSample.CustomGroupBox customGroupBox4;
    }
}


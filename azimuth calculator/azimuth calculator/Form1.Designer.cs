namespace azimuth_calculator
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
            this.inputx1 = new System.Windows.Forms.TextBox();
            this.inputy1 = new System.Windows.Forms.TextBox();
            this.inputx2 = new System.Windows.Forms.TextBox();
            this.inputy2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatebotton = new System.Windows.Forms.Button();
            this.boxAzDeg = new System.Windows.Forms.TextBox();
            this.boxAzRad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputx1
            // 
            this.inputx1.Location = new System.Drawing.Point(97, 30);
            this.inputx1.Name = "inputx1";
            this.inputx1.Size = new System.Drawing.Size(153, 22);
            this.inputx1.TabIndex = 0;
            this.inputx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputx1_KeyPress);
            // 
            // inputy1
            // 
            this.inputy1.Location = new System.Drawing.Point(97, 96);
            this.inputy1.Name = "inputy1";
            this.inputy1.Size = new System.Drawing.Size(153, 22);
            this.inputy1.TabIndex = 1;
            this.inputy1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputy1_KeyPress);
            // 
            // inputx2
            // 
            this.inputx2.Location = new System.Drawing.Point(437, 30);
            this.inputx2.Name = "inputx2";
            this.inputx2.Size = new System.Drawing.Size(153, 22);
            this.inputx2.TabIndex = 2;
            this.inputx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputx2_KeyPress);
            // 
            // inputy2
            // 
            this.inputy2.Location = new System.Drawing.Point(437, 96);
            this.inputy2.Name = "inputy2";
            this.inputy2.Size = new System.Drawing.Size(153, 22);
            this.inputy2.TabIndex = 3;
            this.inputy2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputy2_KeyPress);
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(66, 33);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(25, 17);
            this.X1.TabIndex = 4;
            this.X1.Text = "X1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y2";
            // 
            // calculatebotton
            // 
            this.calculatebotton.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebotton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatebotton.Location = new System.Drawing.Point(270, 190);
            this.calculatebotton.Name = "calculatebotton";
            this.calculatebotton.Size = new System.Drawing.Size(139, 67);
            this.calculatebotton.TabIndex = 8;
            this.calculatebotton.Text = "Calculate";
            this.calculatebotton.UseVisualStyleBackColor = true;
            this.calculatebotton.Click += new System.EventHandler(this.calculatebotton_Click);
            // 
            // boxAzDeg
            // 
            this.boxAzDeg.BackColor = System.Drawing.Color.Gray;
            this.boxAzDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAzDeg.ForeColor = System.Drawing.Color.Yellow;
            this.boxAzDeg.Location = new System.Drawing.Point(97, 280);
            this.boxAzDeg.Name = "boxAzDeg";
            this.boxAzDeg.Size = new System.Drawing.Size(153, 28);
            this.boxAzDeg.TabIndex = 9;
            // 
            // boxAzRad
            // 
            this.boxAzRad.BackColor = System.Drawing.Color.Gray;
            this.boxAzRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAzRad.ForeColor = System.Drawing.Color.Yellow;
            this.boxAzRad.Location = new System.Drawing.Point(437, 280);
            this.boxAzRad.Name = "boxAzRad";
            this.boxAzRad.Size = new System.Drawing.Size(153, 28);
            this.boxAzRad.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(723, 395);
            this.Controls.Add(this.boxAzRad);
            this.Controls.Add(this.boxAzDeg);
            this.Controls.Add(this.calculatebotton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.inputy2);
            this.Controls.Add(this.inputx2);
            this.Controls.Add(this.inputy1);
            this.Controls.Add(this.inputx1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Azimuth Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputx1;
        private System.Windows.Forms.TextBox inputy1;
        private System.Windows.Forms.TextBox inputx2;
        private System.Windows.Forms.TextBox inputy2;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculatebotton;
        private System.Windows.Forms.TextBox boxAzDeg;
        private System.Windows.Forms.TextBox boxAzRad;
    }
}


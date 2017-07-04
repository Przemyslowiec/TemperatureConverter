namespace WindowsFormsApplication1
{
    partial class window
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
            this.celsjus = new System.Windows.Forms.Label();
            this.celsjus_textBox = new System.Windows.Forms.TextBox();
            this.kelvin_textBox = new System.Windows.Forms.TextBox();
            this.ferenheit_textBox = new System.Windows.Forms.TextBox();
            this.Kelvin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // celsjus
            // 
            this.celsjus.AutoSize = true;
            this.celsjus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.celsjus.Location = new System.Drawing.Point(219, 49);
            this.celsjus.Name = "celsjus";
            this.celsjus.Size = new System.Drawing.Size(100, 29);
            this.celsjus.TabIndex = 0;
            this.celsjus.Text = "Celsjus";
            this.celsjus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // celsjus_textBox
            // 
            this.celsjus_textBox.Location = new System.Drawing.Point(57, 49);
            this.celsjus_textBox.Name = "celsjus_textBox";
            this.celsjus_textBox.Size = new System.Drawing.Size(156, 22);
            this.celsjus_textBox.TabIndex = 1;
            this.celsjus_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celsjus_eneter);
            // 
            // kelvin_textBox
            // 
            this.kelvin_textBox.Location = new System.Drawing.Point(57, 95);
            this.kelvin_textBox.Name = "kelvin_textBox";
            this.kelvin_textBox.Size = new System.Drawing.Size(156, 22);
            this.kelvin_textBox.TabIndex = 2;
            this.kelvin_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kelvin_enter);
            // 
            // ferenheit_textBox
            // 
            this.ferenheit_textBox.Location = new System.Drawing.Point(57, 143);
            this.ferenheit_textBox.Name = "ferenheit_textBox";
            this.ferenheit_textBox.Size = new System.Drawing.Size(156, 22);
            this.ferenheit_textBox.TabIndex = 3;
            this.ferenheit_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ferenheit_enter);
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kelvin.Location = new System.Drawing.Point(219, 92);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(72, 25);
            this.Kelvin.TabIndex = 4;
            this.Kelvin.Text = "Kelvin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(219, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ferenheit";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.ferenheit_textBox);
            this.Controls.Add(this.kelvin_textBox);
            this.Controls.Add(this.celsjus_textBox);
            this.Controls.Add(this.celsjus);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "window";
            this.Text = "TempConv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label celsjus;
        private System.Windows.Forms.TextBox celsjus_textBox;
        private System.Windows.Forms.TextBox kelvin_textBox;
        private System.Windows.Forms.TextBox ferenheit_textBox;
        private System.Windows.Forms.Label Kelvin;
        private System.Windows.Forms.Label label2;
    }
}


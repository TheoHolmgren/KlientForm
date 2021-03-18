namespace KlientForm
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
            this.tbxIPAdress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSägHej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxIPAdress
            // 
            this.tbxIPAdress.Location = new System.Drawing.Point(78, 71);
            this.tbxIPAdress.Name = "tbxIPAdress";
            this.tbxIPAdress.Size = new System.Drawing.Size(140, 28);
            this.tbxIPAdress.TabIndex = 0;
            this.tbxIPAdress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serverns IP-adress";
            // 
            // btnSägHej
            // 
            this.btnSägHej.Location = new System.Drawing.Point(78, 115);
            this.btnSägHej.Name = "btnSägHej";
            this.btnSägHej.Size = new System.Drawing.Size(140, 33);
            this.btnSägHej.TabIndex = 2;
            this.btnSägHej.Text = "Säg Hej!";
            this.btnSägHej.UseVisualStyleBackColor = true;
            this.btnSägHej.Click += new System.EventHandler(this.btnSägHej_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 160);
            this.Controls.Add(this.btnSägHej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIPAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxIPAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSägHej;
    }
}


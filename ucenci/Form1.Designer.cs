namespace ucenci
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
            this.Vnosbutton = new System.Windows.Forms.Button();
            this.Urejanjebutton = new System.Windows.Forms.Button();
            this.brisanjebutton3 = new System.Windows.Forms.Button();
            this.prikazbutton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vnosbutton
            // 
            this.Vnosbutton.Location = new System.Drawing.Point(47, 12);
            this.Vnosbutton.Name = "Vnosbutton";
            this.Vnosbutton.Size = new System.Drawing.Size(107, 55);
            this.Vnosbutton.TabIndex = 1;
            this.Vnosbutton.Text = "Vnos";
            this.Vnosbutton.UseVisualStyleBackColor = true;
            this.Vnosbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Urejanjebutton
            // 
            this.Urejanjebutton.Location = new System.Drawing.Point(47, 73);
            this.Urejanjebutton.Name = "Urejanjebutton";
            this.Urejanjebutton.Size = new System.Drawing.Size(107, 58);
            this.Urejanjebutton.TabIndex = 2;
            this.Urejanjebutton.Text = "Urejanje";
            this.Urejanjebutton.UseVisualStyleBackColor = true;
            this.Urejanjebutton.Click += new System.EventHandler(this.Urejanjebutton_Click);
            // 
            // brisanjebutton3
            // 
            this.brisanjebutton3.Location = new System.Drawing.Point(47, 137);
            this.brisanjebutton3.Name = "brisanjebutton3";
            this.brisanjebutton3.Size = new System.Drawing.Size(107, 61);
            this.brisanjebutton3.TabIndex = 3;
            this.brisanjebutton3.Text = "Brisanje";
            this.brisanjebutton3.UseVisualStyleBackColor = true;
            this.brisanjebutton3.Click += new System.EventHandler(this.brisanjebutton3_Click);
            // 
            // prikazbutton4
            // 
            this.prikazbutton4.Location = new System.Drawing.Point(47, 204);
            this.prikazbutton4.Name = "prikazbutton4";
            this.prikazbutton4.Size = new System.Drawing.Size(107, 55);
            this.prikazbutton4.TabIndex = 4;
            this.prikazbutton4.Text = "Prikaz";
            this.prikazbutton4.UseVisualStyleBackColor = true;
            this.prikazbutton4.Click += new System.EventHandler(this.prikazbutton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 289);
            this.Controls.Add(this.prikazbutton4);
            this.Controls.Add(this.brisanjebutton3);
            this.Controls.Add(this.Urejanjebutton);
            this.Controls.Add(this.Vnosbutton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Vnosbutton;
        private System.Windows.Forms.Button Urejanjebutton;
        private System.Windows.Forms.Button brisanjebutton3;
        private System.Windows.Forms.Button prikazbutton4;
    }
}


namespace Police_App
{
    partial class Home
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
            this.btnChangeCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeCountry
            // 
            this.btnChangeCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeCountry.BackgroundImage = global::Police_App.Properties.Resources.WhatsApp_Image_2023_04_11_at_4_11_08_PM;
            this.btnChangeCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeCountry.Location = new System.Drawing.Point(367, 184);
            this.btnChangeCountry.Name = "btnChangeCountry";
            this.btnChangeCountry.Size = new System.Drawing.Size(132, 80);
            this.btnChangeCountry.TabIndex = 1;
            this.btnChangeCountry.UseVisualStyleBackColor = true;
            this.btnChangeCountry.Click += new System.EventHandler(this.btnChangeCountry_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 321);
            this.Controls.Add(this.btnChangeCountry);
            this.Name = "Home";
            this.Text = "HomeContents";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangeCountry;
    }
}
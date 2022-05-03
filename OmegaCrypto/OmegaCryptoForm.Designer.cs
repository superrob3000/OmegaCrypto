
namespace OmegaCrypto
{
    partial class OmegaCryptoForm
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
            this.genkeys_button = new System.Windows.Forms.Button();
            this.Public_textbox = new System.Windows.Forms.TextBox();
            this.Private_textbox = new System.Windows.Forms.TextBox();
            this.Public_label = new System.Windows.Forms.Label();
            this.Private_label = new System.Windows.Forms.Label();
            this.sign_button = new System.Windows.Forms.Button();
            this.verify_button = new System.Windows.Forms.Button();
            this.loadkeys_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genkeys_button
            // 
            this.genkeys_button.Location = new System.Drawing.Point(215, 415);
            this.genkeys_button.Name = "genkeys_button";
            this.genkeys_button.Size = new System.Drawing.Size(145, 23);
            this.genkeys_button.TabIndex = 0;
            this.genkeys_button.Text = "Generate New Keys";
            this.genkeys_button.UseVisualStyleBackColor = true;
            this.genkeys_button.Click += new System.EventHandler(this.genkeys_button_Click);
            // 
            // Public_textbox
            // 
            this.Public_textbox.Location = new System.Drawing.Point(50, 35);
            this.Public_textbox.Multiline = true;
            this.Public_textbox.Name = "Public_textbox";
            this.Public_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Public_textbox.Size = new System.Drawing.Size(672, 157);
            this.Public_textbox.TabIndex = 1;
            // 
            // Private_textbox
            // 
            this.Private_textbox.Location = new System.Drawing.Point(50, 243);
            this.Private_textbox.Multiline = true;
            this.Private_textbox.Name = "Private_textbox";
            this.Private_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Private_textbox.Size = new System.Drawing.Size(672, 157);
            this.Private_textbox.TabIndex = 2;
            // 
            // Public_label
            // 
            this.Public_label.AutoSize = true;
            this.Public_label.Location = new System.Drawing.Point(50, 13);
            this.Public_label.Name = "Public_label";
            this.Public_label.Size = new System.Drawing.Size(36, 13);
            this.Public_label.TabIndex = 3;
            this.Public_label.Text = "Public";
            // 
            // Private_label
            // 
            this.Private_label.AutoSize = true;
            this.Private_label.Location = new System.Drawing.Point(50, 218);
            this.Private_label.Name = "Private_label";
            this.Private_label.Size = new System.Drawing.Size(40, 13);
            this.Private_label.TabIndex = 4;
            this.Private_label.Text = "Private";
            // 
            // sign_button
            // 
            this.sign_button.Location = new System.Drawing.Point(566, 415);
            this.sign_button.Name = "sign_button";
            this.sign_button.Size = new System.Drawing.Size(75, 23);
            this.sign_button.TabIndex = 5;
            this.sign_button.Text = "Sign File";
            this.sign_button.UseVisualStyleBackColor = true;
            this.sign_button.Click += new System.EventHandler(this.sign_button_Click);
            // 
            // verify_button
            // 
            this.verify_button.Location = new System.Drawing.Point(647, 415);
            this.verify_button.Name = "verify_button";
            this.verify_button.Size = new System.Drawing.Size(75, 23);
            this.verify_button.TabIndex = 6;
            this.verify_button.Text = "Verify File";
            this.verify_button.UseVisualStyleBackColor = true;
            this.verify_button.Click += new System.EventHandler(this.verify_button_Click);
            // 
            // loadkeys_button
            // 
            this.loadkeys_button.Location = new System.Drawing.Point(53, 415);
            this.loadkeys_button.Name = "loadkeys_button";
            this.loadkeys_button.Size = new System.Drawing.Size(156, 23);
            this.loadkeys_button.TabIndex = 7;
            this.loadkeys_button.Text = "Load Keys From File";
            this.loadkeys_button.UseVisualStyleBackColor = true;
            this.loadkeys_button.Click += new System.EventHandler(this.loadkeys_button_Click);
            // 
            // OmegaCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadkeys_button);
            this.Controls.Add(this.verify_button);
            this.Controls.Add(this.sign_button);
            this.Controls.Add(this.Private_label);
            this.Controls.Add(this.Public_label);
            this.Controls.Add(this.Private_textbox);
            this.Controls.Add(this.Public_textbox);
            this.Controls.Add(this.genkeys_button);
            this.Name = "OmegaCryptoForm";
            this.Text = "OmegaCrypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genkeys_button;
        private System.Windows.Forms.TextBox Public_textbox;
        private System.Windows.Forms.TextBox Private_textbox;
        private System.Windows.Forms.Label Public_label;
        private System.Windows.Forms.Label Private_label;
        private System.Windows.Forms.Button sign_button;
        private System.Windows.Forms.Button verify_button;
        private System.Windows.Forms.Button loadkeys_button;
    }
}


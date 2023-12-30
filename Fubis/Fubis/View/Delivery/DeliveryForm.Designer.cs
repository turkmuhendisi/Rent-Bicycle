namespace Fubis
{
    partial class DeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.cardNumberField = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardNumberField
            // 
            this.cardNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cardNumberField.Location = new System.Drawing.Point(281, 215);
            this.cardNumberField.Name = "cardNumberField";
            this.cardNumberField.Size = new System.Drawing.Size(460, 22);
            this.cardNumberField.TabIndex = 5;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Transparent;
            this.continueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.continueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueButton.FlatAppearance.BorderSize = 0;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Location = new System.Drawing.Point(302, 447);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(420, 53);
            this.continueButton.TabIndex = 4;
            this.continueButton.UseVisualStyleBackColor = false;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.cardNumberField);
            this.Controls.Add(this.continueButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNumberField;
        private System.Windows.Forms.Button continueButton;
    }
}
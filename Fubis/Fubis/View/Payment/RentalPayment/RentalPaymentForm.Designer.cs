namespace Fubis.View.Payment.RentalPayment
{
    partial class RentalPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalPaymentForm));
            this.confirmButton = new System.Windows.Forms.Button();
            this.verificationCodeField = new System.Windows.Forms.TextBox();
            this.cardNumberField = new System.Windows.Forms.TextBox();
            this.sendCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(196, 305);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(210, 39);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // verificationCodeField
            // 
            this.verificationCodeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verificationCodeField.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verificationCodeField.Location = new System.Drawing.Point(90, 220);
            this.verificationCodeField.Name = "verificationCodeField";
            this.verificationCodeField.Size = new System.Drawing.Size(168, 18);
            this.verificationCodeField.TabIndex = 8;
            // 
            // cardNumberField
            // 
            this.cardNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberField.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardNumberField.Location = new System.Drawing.Point(90, 117);
            this.cardNumberField.MaxLength = 16;
            this.cardNumberField.Name = "cardNumberField";
            this.cardNumberField.Size = new System.Drawing.Size(419, 18);
            this.cardNumberField.TabIndex = 7;
            // 
            // sendCodeButton
            // 
            this.sendCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.sendCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendCodeButton.FlatAppearance.BorderSize = 0;
            this.sendCodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendCodeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCodeButton.Location = new System.Drawing.Point(385, 150);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(139, 28);
            this.sendCodeButton.TabIndex = 6;
            this.sendCodeButton.UseVisualStyleBackColor = false;
            // 
            // RentalPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.verificationCodeField);
            this.Controls.Add(this.cardNumberField);
            this.Controls.Add(this.sendCodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalPaymentForm";
            this.Text = "RentalPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox verificationCodeField;
        private System.Windows.Forms.TextBox cardNumberField;
        private System.Windows.Forms.Button sendCodeButton;
    }
}
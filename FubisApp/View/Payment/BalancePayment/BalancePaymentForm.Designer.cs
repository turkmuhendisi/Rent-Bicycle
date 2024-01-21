namespace Fubis
{
    partial class BalancePaymentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalancePaymentForm));
            this.sendCodeButton = new System.Windows.Forms.Button();
            this.cardNumberField = new System.Windows.Forms.TextBox();
            this.verificationCodeField = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.balancePaymentProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.verificationCodeTimerLabel = new System.Windows.Forms.Label();
            this.verificationCodeTimer = new System.Windows.Forms.Timer(this.components);
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.sendCodeButton.Location = new System.Drawing.Point(385, 156);
            this.sendCodeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendCodeButton.Name = "sendCodeButton";
            this.sendCodeButton.Size = new System.Drawing.Size(139, 29);
            this.sendCodeButton.TabIndex = 2;
            this.sendCodeButton.UseVisualStyleBackColor = false;
            // 
            // cardNumberField
            // 
            this.cardNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberField.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardNumberField.Location = new System.Drawing.Point(85, 124);
            this.cardNumberField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cardNumberField.MaxLength = 16;
            this.cardNumberField.Name = "cardNumberField";
            this.cardNumberField.Size = new System.Drawing.Size(430, 18);
            this.cardNumberField.TabIndex = 3;
            // 
            // verificationCodeField
            // 
            this.verificationCodeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verificationCodeField.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verificationCodeField.Location = new System.Drawing.Point(85, 223);
            this.verificationCodeField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.verificationCodeField.Name = "verificationCodeField";
            this.verificationCodeField.Size = new System.Drawing.Size(176, 18);
            this.verificationCodeField.TabIndex = 4;
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
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(209, 39);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // balancePaymentProgressBar
            // 
            this.balancePaymentProgressBar.BackColor = System.Drawing.SystemColors.Window;
            this.balancePaymentProgressBar.Location = new System.Drawing.Point(13, 361);
            this.balancePaymentProgressBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.balancePaymentProgressBar.Name = "balancePaymentProgressBar";
            this.balancePaymentProgressBar.Size = new System.Drawing.Size(574, 27);
            this.balancePaymentProgressBar.TabIndex = 6;
            this.balancePaymentProgressBar.Visible = false;
            // 
            // verificationCodeTimerLabel
            // 
            this.verificationCodeTimerLabel.AutoSize = true;
            this.verificationCodeTimerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verificationCodeTimerLabel.Location = new System.Drawing.Point(278, 217);
            this.verificationCodeTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verificationCodeTimerLabel.Name = "verificationCodeTimerLabel";
            this.verificationCodeTimerLabel.Size = new System.Drawing.Size(54, 30);
            this.verificationCodeTimerLabel.TabIndex = 7;
            this.verificationCodeTimerLabel.Text = "2:59";
            this.verificationCodeTimerLabel.Visible = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::FubisApp.Properties.Resources.close;
            this.closePictureBox.Location = new System.Drawing.Point(550, 12);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(37, 37);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 8;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // BalancePaymentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::FubisApp.Properties.Resources.BalancePayment_Light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.verificationCodeTimerLabel);
            this.Controls.Add(this.balancePaymentProgressBar);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.verificationCodeField);
            this.Controls.Add(this.cardNumberField);
            this.Controls.Add(this.sendCodeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BalancePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendCodeButton;
        private System.Windows.Forms.TextBox cardNumberField;
        private System.Windows.Forms.TextBox verificationCodeField;
        private System.Windows.Forms.Button confirmButton;
        public System.Windows.Forms.ProgressBar balancePaymentProgressBar;
        public System.Windows.Forms.Timer progressBarTimer;
        public System.Windows.Forms.Label verificationCodeTimerLabel;
        public System.Windows.Forms.Timer verificationCodeTimer;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}
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
            this.deliveryButton = new System.Windows.Forms.Button();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardNumberField
            // 
            this.cardNumberField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.cardNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNumberField.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardNumberField.Location = new System.Drawing.Point(328, 307);
            this.cardNumberField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cardNumberField.Name = "cardNumberField";
            this.cardNumberField.Size = new System.Drawing.Size(363, 22);
            this.cardNumberField.TabIndex = 5;
            // 
            // deliveryButton
            // 
            this.deliveryButton.BackColor = System.Drawing.Color.Transparent;
            this.deliveryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deliveryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveryButton.FlatAppearance.BorderSize = 0;
            this.deliveryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deliveryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliveryButton.Location = new System.Drawing.Point(405, 376);
            this.deliveryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(209, 39);
            this.deliveryButton.TabIndex = 4;
            this.deliveryButton.UseVisualStyleBackColor = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::FubisApp.Properties.Resources.close;
            this.closePictureBox.Location = new System.Drawing.Point(974, 12);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(37, 37);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePictureBox.TabIndex = 6;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.cardNumberField);
            this.Controls.Add(this.deliveryButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryForm";
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardNumberField;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}
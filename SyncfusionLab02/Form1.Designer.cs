namespace SyncfusionLab02
{
    partial class BarcodeQRcodeGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.BarcodeTextBox = new System.Windows.Forms.TextBox();
            this.BarcodeButton = new System.Windows.Forms.Button();
            this.QRButton = new System.Windows.Forms.Button();
            this.QRTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GeneratePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode:";
            // 
            // BarcodeTextBox
            // 
            this.BarcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BarcodeTextBox.Location = new System.Drawing.Point(136, 39);
            this.BarcodeTextBox.Name = "BarcodeTextBox";
            this.BarcodeTextBox.Size = new System.Drawing.Size(503, 34);
            this.BarcodeTextBox.TabIndex = 1;
            // 
            // BarcodeButton
            // 
            this.BarcodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarcodeButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BarcodeButton.Location = new System.Drawing.Point(655, 37);
            this.BarcodeButton.Name = "BarcodeButton";
            this.BarcodeButton.Size = new System.Drawing.Size(133, 38);
            this.BarcodeButton.TabIndex = 2;
            this.BarcodeButton.Text = "Generate";
            this.BarcodeButton.UseVisualStyleBackColor = true;
            this.BarcodeButton.Click += new System.EventHandler(this.BarcodeButton_Click);
            // 
            // QRButton
            // 
            this.QRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QRButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.QRButton.Location = new System.Drawing.Point(655, 97);
            this.QRButton.Name = "QRButton";
            this.QRButton.Size = new System.Drawing.Size(133, 38);
            this.QRButton.TabIndex = 5;
            this.QRButton.Text = "Generate";
            this.QRButton.UseVisualStyleBackColor = true;
            this.QRButton.Click += new System.EventHandler(this.QRButton_Click);
            // 
            // QRTextBox
            // 
            this.QRTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.QRTextBox.Location = new System.Drawing.Point(136, 99);
            this.QRTextBox.Name = "QRTextBox";
            this.QRTextBox.Size = new System.Drawing.Size(503, 34);
            this.QRTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "QRcode:";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SaveButton.Location = new System.Drawing.Point(332, 452);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(118, 36);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GeneratePictureBox
            // 
            this.GeneratePictureBox.Location = new System.Drawing.Point(136, 156);
            this.GeneratePictureBox.Name = "GeneratePictureBox";
            this.GeneratePictureBox.Size = new System.Drawing.Size(503, 284);
            this.GeneratePictureBox.TabIndex = 7;
            this.GeneratePictureBox.TabStop = false;
            // 
            // BarcodeQRcodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.GeneratePictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QRButton);
            this.Controls.Add(this.QRTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarcodeButton);
            this.Controls.Add(this.BarcodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BarcodeQRcodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode and QRcode Generator";
            this.Load += new System.EventHandler(this.BarcodeQRcodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneratePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarcodeTextBox;
        private System.Windows.Forms.Button BarcodeButton;
        private System.Windows.Forms.Button QRButton;
        private System.Windows.Forms.TextBox QRTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox GeneratePictureBox;
    }
}


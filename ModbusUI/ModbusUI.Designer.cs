
namespace ModbusUI
{
    partial class ModbusUI
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
            this.readInputButton = new System.Windows.Forms.Button();
            this.readAddressTextBox = new System.Windows.Forms.TextBox();
            this.readInputLabel = new System.Windows.Forms.Label();
            this.readResultListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // readInputButton
            // 
            this.readInputButton.Location = new System.Drawing.Point(158, 168);
            this.readInputButton.Name = "readInputButton";
            this.readInputButton.Size = new System.Drawing.Size(129, 38);
            this.readInputButton.TabIndex = 0;
            this.readInputButton.Text = "Read Input";
            this.readInputButton.UseVisualStyleBackColor = true;
            this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
            // 
            // readAddressTextBox
            // 
            this.readAddressTextBox.Location = new System.Drawing.Point(158, 121);
            this.readAddressTextBox.Name = "readAddressTextBox";
            this.readAddressTextBox.Size = new System.Drawing.Size(129, 29);
            this.readAddressTextBox.TabIndex = 1;
            this.readAddressTextBox.Text = "0";
            this.readAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readInputLabel
            // 
            this.readInputLabel.AutoSize = true;
            this.readInputLabel.Location = new System.Drawing.Point(181, 82);
            this.readInputLabel.Name = "readInputLabel";
            this.readInputLabel.Size = new System.Drawing.Size(85, 21);
            this.readInputLabel.TabIndex = 2;
            this.readInputLabel.Text = "Read Input";
            // 
            // readResultListBox
            // 
            this.readResultListBox.FormattingEnabled = true;
            this.readResultListBox.ItemHeight = 21;
            this.readResultListBox.Location = new System.Drawing.Point(81, 235);
            this.readResultListBox.Name = "readResultListBox";
            this.readResultListBox.Size = new System.Drawing.Size(274, 193);
            this.readResultListBox.TabIndex = 3;
            // 
            // ModbusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 477);
            this.Controls.Add(this.readResultListBox);
            this.Controls.Add(this.readInputLabel);
            this.Controls.Add(this.readAddressTextBox);
            this.Controls.Add(this.readInputButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModbusUI";
            this.Text = "Modbus Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readInputButton;
        private System.Windows.Forms.TextBox readAddressTextBox;
        private System.Windows.Forms.Label readInputLabel;
        private System.Windows.Forms.ListBox readResultListBox;
    }
}


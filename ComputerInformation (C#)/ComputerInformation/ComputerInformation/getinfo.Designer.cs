namespace ComputerInformation
{
    partial class getinfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InventNoTextBox = new System.Windows.Forms.TextBox();
            this.KabinetTextBox = new System.Windows.Forms.TextBox();
            this.nPCTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кабинет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "№ компьютера";
            // 
            // InventNoTextBox
            // 
            this.InventNoTextBox.Location = new System.Drawing.Point(129, 29);
            this.InventNoTextBox.Name = "InventNoTextBox";
            this.InventNoTextBox.Size = new System.Drawing.Size(208, 20);
            this.InventNoTextBox.TabIndex = 4;
            // 
            // KabinetTextBox
            // 
            this.KabinetTextBox.Location = new System.Drawing.Point(129, 55);
            this.KabinetTextBox.Name = "KabinetTextBox";
            this.KabinetTextBox.Size = new System.Drawing.Size(208, 20);
            this.KabinetTextBox.TabIndex = 5;
            // 
            // nPCTextBox
            // 
            this.nPCTextBox.Location = new System.Drawing.Point(129, 81);
            this.nPCTextBox.Name = "nPCTextBox";
            this.nPCTextBox.Size = new System.Drawing.Size(208, 20);
            this.nPCTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(262, 127);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // getinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 161);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nPCTextBox);
            this.Controls.Add(this.KabinetTextBox);
            this.Controls.Add(this.InventNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "getinfo";
            this.Text = "getinfo";
            this.Load += new System.EventHandler(this.getinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InventNoTextBox;
        private System.Windows.Forms.TextBox KabinetTextBox;
        private System.Windows.Forms.TextBox nPCTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendButton;
    }
}
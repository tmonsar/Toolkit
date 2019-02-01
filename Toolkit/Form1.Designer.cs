namespace Toolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolboxEnterButton = new System.Windows.Forms.Button();
            this.ToolboxNumberLabel = new System.Windows.Forms.Label();
            this.ToolboxTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolboxErrorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DriveLetterLabel = new System.Windows.Forms.Label();
            this.MapLetterTextBox = new System.Windows.Forms.TextBox();
            this.UNCPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MapDriveBackButton = new System.Windows.Forms.Button();
            this.MapDriveErrorLabel = new System.Windows.Forms.Label();
            this.MapDriveEnterButton = new System.Windows.Forms.Button();
            this.MapDriveTextBox = new System.Windows.Forms.TextBox();
            this.MapPasswordTextBox = new System.Windows.Forms.TextBox();
            this.MapUserNameTextBox = new System.Windows.Forms.TextBox();
            this.MapDriveNumberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolboxEnterButton
            // 
            this.ToolboxEnterButton.Location = new System.Drawing.Point(196, 124);
            this.ToolboxEnterButton.Name = "ToolboxEnterButton";
            this.ToolboxEnterButton.Size = new System.Drawing.Size(75, 23);
            this.ToolboxEnterButton.TabIndex = 0;
            this.ToolboxEnterButton.Text = "Enter";
            this.ToolboxEnterButton.UseVisualStyleBackColor = true;
            this.ToolboxEnterButton.Click += new System.EventHandler(this.ToolboxEnterButton_Click);
            // 
            // ToolboxNumberLabel
            // 
            this.ToolboxNumberLabel.AutoSize = true;
            this.ToolboxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolboxNumberLabel.Location = new System.Drawing.Point(295, 51);
            this.ToolboxNumberLabel.Name = "ToolboxNumberLabel";
            this.ToolboxNumberLabel.Size = new System.Drawing.Size(314, 170);
            this.ToolboxNumberLabel.TabIndex = 4;
            this.ToolboxNumberLabel.Text = resources.GetString("ToolboxNumberLabel.Text");
            // 
            // ToolboxTextBox
            // 
            this.ToolboxTextBox.Location = new System.Drawing.Point(70, 124);
            this.ToolboxTextBox.Name = "ToolboxTextBox";
            this.ToolboxTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToolboxTextBox.TabIndex = 5;
            this.ToolboxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolboxTextBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.ToolboxErrorLabel);
            this.panel1.Controls.Add(this.ToolboxNumberLabel);
            this.panel1.Controls.Add(this.ToolboxTextBox);
            this.panel1.Controls.Add(this.ToolboxEnterButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 270);
            this.panel1.TabIndex = 6;
            // 
            // ToolboxErrorLabel
            // 
            this.ToolboxErrorLabel.AutoSize = true;
            this.ToolboxErrorLabel.Location = new System.Drawing.Point(67, 171);
            this.ToolboxErrorLabel.Name = "ToolboxErrorLabel";
            this.ToolboxErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ToolboxErrorLabel.TabIndex = 6;
            this.ToolboxErrorLabel.Text = "ErrorLabel";
            this.ToolboxErrorLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.DriveLetterLabel);
            this.panel2.Controls.Add(this.MapLetterTextBox);
            this.panel2.Controls.Add(this.UNCPathTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.MapDriveBackButton);
            this.panel2.Controls.Add(this.MapDriveErrorLabel);
            this.panel2.Controls.Add(this.MapDriveEnterButton);
            this.panel2.Controls.Add(this.MapDriveTextBox);
            this.panel2.Controls.Add(this.MapPasswordTextBox);
            this.panel2.Controls.Add(this.MapUserNameTextBox);
            this.panel2.Controls.Add(this.MapDriveNumberLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 230);
            this.panel2.TabIndex = 7;
            // 
            // DriveLetterLabel
            // 
            this.DriveLetterLabel.AutoSize = true;
            this.DriveLetterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriveLetterLabel.Location = new System.Drawing.Point(121, 123);
            this.DriveLetterLabel.Name = "DriveLetterLabel";
            this.DriveLetterLabel.Size = new System.Drawing.Size(13, 17);
            this.DriveLetterLabel.TabIndex = 27;
            this.DriveLetterLabel.Text = ":";
            this.DriveLetterLabel.Visible = false;
            // 
            // MapLetterTextBox
            // 
            this.MapLetterTextBox.Location = new System.Drawing.Point(70, 122);
            this.MapLetterTextBox.Name = "MapLetterTextBox";
            this.MapLetterTextBox.Size = new System.Drawing.Size(52, 20);
            this.MapLetterTextBox.TabIndex = 26;
            this.MapLetterTextBox.Visible = false;
            // 
            // UNCPathTextBox
            // 
            this.UNCPathTextBox.Location = new System.Drawing.Point(133, 122);
            this.UNCPathTextBox.Name = "UNCPathTextBox";
            this.UNCPathTextBox.Size = new System.Drawing.Size(383, 20);
            this.UNCPathTextBox.TabIndex = 25;
            this.UNCPathTextBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "RACF ID";
            // 
            // MapDriveBackButton
            // 
            this.MapDriveBackButton.Location = new System.Drawing.Point(83, 180);
            this.MapDriveBackButton.Name = "MapDriveBackButton";
            this.MapDriveBackButton.Size = new System.Drawing.Size(75, 20);
            this.MapDriveBackButton.TabIndex = 22;
            this.MapDriveBackButton.Text = "Back";
            this.MapDriveBackButton.UseVisualStyleBackColor = true;
            this.MapDriveBackButton.Click += new System.EventHandler(this.MapDriveBackButton_Click_1);
            // 
            // MapDriveErrorLabel
            // 
            this.MapDriveErrorLabel.AutoSize = true;
            this.MapDriveErrorLabel.Location = new System.Drawing.Point(67, 106);
            this.MapDriveErrorLabel.Name = "MapDriveErrorLabel";
            this.MapDriveErrorLabel.Size = new System.Drawing.Size(362, 13);
            this.MapDriveErrorLabel.TabIndex = 21;
            this.MapDriveErrorLabel.Text = "You\'ll usually only need to enter your credentials from administrator account.";
            // 
            // MapDriveEnterButton
            // 
            this.MapDriveEnterButton.Location = new System.Drawing.Point(196, 51);
            this.MapDriveEnterButton.Name = "MapDriveEnterButton";
            this.MapDriveEnterButton.Size = new System.Drawing.Size(75, 23);
            this.MapDriveEnterButton.TabIndex = 20;
            this.MapDriveEnterButton.Text = "Enter";
            this.MapDriveEnterButton.UseVisualStyleBackColor = true;
            this.MapDriveEnterButton.Click += new System.EventHandler(this.MapDriveEnterButton_Click_1);
            // 
            // MapDriveTextBox
            // 
            this.MapDriveTextBox.Location = new System.Drawing.Point(70, 51);
            this.MapDriveTextBox.Name = "MapDriveTextBox";
            this.MapDriveTextBox.Size = new System.Drawing.Size(100, 20);
            this.MapDriveTextBox.TabIndex = 19;
            this.MapDriveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MapDriveTextBox_KeyPress);
            // 
            // MapPasswordTextBox
            // 
            this.MapPasswordTextBox.Location = new System.Drawing.Point(280, 180);
            this.MapPasswordTextBox.Name = "MapPasswordTextBox";
            this.MapPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.MapPasswordTextBox.TabIndex = 18;
            this.MapPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // MapUserNameTextBox
            // 
            this.MapUserNameTextBox.Location = new System.Drawing.Point(280, 154);
            this.MapUserNameTextBox.Name = "MapUserNameTextBox";
            this.MapUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MapUserNameTextBox.TabIndex = 17;
            // 
            // MapDriveNumberLabel
            // 
            this.MapDriveNumberLabel.AutoSize = true;
            this.MapDriveNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapDriveNumberLabel.Location = new System.Drawing.Point(304, 21);
            this.MapDriveNumberLabel.Name = "MapDriveNumberLabel";
            this.MapDriveNumberLabel.Size = new System.Drawing.Size(252, 85);
            this.MapDriveNumberLabel.TabIndex = 16;
            this.MapDriveNumberLabel.Text = "1 - \\\\jdnet\\jdmedia\r\n2 - \\\\wdx0000041205a\\tier2share\\\r\n3 - Specific network drive" +
    "\r\n4 - Back\r\n5 - Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToolboxEnterButton;
        private System.Windows.Forms.Label ToolboxNumberLabel;
        private System.Windows.Forms.TextBox ToolboxTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MapDriveBackButton;
        private System.Windows.Forms.Label MapDriveErrorLabel;
        private System.Windows.Forms.Button MapDriveEnterButton;
        private System.Windows.Forms.TextBox MapDriveTextBox;
        private System.Windows.Forms.TextBox MapPasswordTextBox;
        private System.Windows.Forms.TextBox MapUserNameTextBox;
        private System.Windows.Forms.Label MapDriveNumberLabel;
        private System.Windows.Forms.TextBox UNCPathTextBox;
        private System.Windows.Forms.Label ToolboxErrorLabel;
        private System.Windows.Forms.Label DriveLetterLabel;
        private System.Windows.Forms.TextBox MapLetterTextBox;
    }
}


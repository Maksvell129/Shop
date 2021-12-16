
namespace Shop
{
    partial class RegistrationForm
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
            this.labelClose = new System.Windows.Forms.Label();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(770, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 17);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Animated = true;
            this.textBoxPassword.BorderRadius = 5;
            this.textBoxPassword.BorderThickness = 2;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.Location = new System.Drawing.Point(350, 251);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(247, 42);
            this.textBoxPassword.TabIndex = 30;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(200, 264);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(128, 29);
            this.labelPassword.TabIndex = 29;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Animated = true;
            this.textBoxPhone.BorderRadius = 5;
            this.textBoxPhone.BorderThickness = 2;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.Parent = this.textBoxPhone;
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.FocusedState.Parent = this.textBoxPhone;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.HoverState.Parent = this.textBoxPhone;
            this.textBoxPhone.Location = new System.Drawing.Point(349, 191);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxPhone.PlaceholderText = "Phone";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.ShadowDecoration.Parent = this.textBoxPhone;
            this.textBoxPhone.Size = new System.Drawing.Size(247, 42);
            this.textBoxPhone.TabIndex = 28;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(200, 204);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(88, 29);
            this.labelPhone.TabIndex = 27;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Animated = true;
            this.textBoxAge.BorderRadius = 5;
            this.textBoxAge.BorderThickness = 2;
            this.textBoxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAge.DefaultText = "";
            this.textBoxAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAge.DisabledState.Parent = this.textBoxAge;
            this.textBoxAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAge.FocusedState.Parent = this.textBoxAge;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAge.HoverState.Parent = this.textBoxAge;
            this.textBoxAge.Location = new System.Drawing.Point(349, 129);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.PasswordChar = '\0';
            this.textBoxAge.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxAge.PlaceholderText = "Age";
            this.textBoxAge.SelectedText = "";
            this.textBoxAge.ShadowDecoration.Parent = this.textBoxAge;
            this.textBoxAge.Size = new System.Drawing.Size(247, 42);
            this.textBoxAge.TabIndex = 26;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(200, 142);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(59, 29);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "Age";
            // 
            // textBoxName
            // 
            this.textBoxName.Animated = true;
            this.textBoxName.BorderRadius = 5;
            this.textBoxName.BorderThickness = 2;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.Parent = this.textBoxName;
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.FocusedState.Parent = this.textBoxName;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.HoverState.Parent = this.textBoxName;
            this.textBoxName.Location = new System.Drawing.Point(349, 70);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.SelectedText = "";
            this.textBoxName.ShadowDecoration.Parent = this.textBoxName;
            this.textBoxName.Size = new System.Drawing.Size(247, 42);
            this.textBoxName.TabIndex = 24;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(200, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 29);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Animated = true;
            this.buttonConfirm.AutoRoundedCorners = true;
            this.buttonConfirm.BorderRadius = 28;
            this.buttonConfirm.BorderThickness = 2;
            this.buttonConfirm.CheckedState.Parent = this.buttonConfirm;
            this.buttonConfirm.CustomImages.Parent = this.buttonConfirm;
            this.buttonConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirm.DisabledState.Parent = this.buttonConfirm;
            this.buttonConfirm.FillColor = System.Drawing.Color.White;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonConfirm.ForeColor = System.Drawing.Color.Purple;
            this.buttonConfirm.HoverState.Parent = this.buttonConfirm;
            this.buttonConfirm.Location = new System.Drawing.Point(310, 367);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.ShadowDecoration.Parent = this.buttonConfirm;
            this.buttonConfirm.Size = new System.Drawing.Size(169, 59);
            this.buttonConfirm.TabIndex = 31;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Animated = true;
            this.textBoxConfirmPassword.BorderRadius = 5;
            this.textBoxConfirmPassword.BorderThickness = 2;
            this.textBoxConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxConfirmPassword.DefaultText = "";
            this.textBoxConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxConfirmPassword.DisabledState.Parent = this.textBoxConfirmPassword;
            this.textBoxConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxConfirmPassword.FocusedState.Parent = this.textBoxConfirmPassword;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textBoxConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxConfirmPassword.HoverState.Parent = this.textBoxConfirmPassword;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(350, 305);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textBoxConfirmPassword.PlaceholderText = "Password";
            this.textBoxConfirmPassword.SelectedText = "";
            this.textBoxConfirmPassword.ShadowDecoration.Parent = this.textBoxConfirmPassword;
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(247, 42);
            this.textBoxConfirmPassword.TabIndex = 33;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(102, 318);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(226, 29);
            this.labelConfirmPassword.TabIndex = 32;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(604, 284);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(88, 29);
            this.checkBoxShowPass.TabIndex = 34;
            this.checkBoxShowPass.Text = "Show";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClose;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Button buttonConfirm;
        private Guna.UI2.WinForms.Guna2TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
    }
}
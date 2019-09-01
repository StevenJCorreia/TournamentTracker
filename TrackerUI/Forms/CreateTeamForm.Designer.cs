namespace TrackerUI.Forms
{
    partial class CreateTeamForm
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
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.RemoveSelectedMemberButton = new System.Windows.Forms.Button();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellphoneValue = new System.Windows.Forms.TextBox();
            this.AddNewMember = new System.Windows.Forms.GroupBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.SelectMemberDropDown = new System.Windows.Forms.ComboBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SelectMemberLabel = new System.Windows.Forms.Label();
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.AddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(170, 526);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(270, 59);
            this.CreateTeamButton.TabIndex = 35;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // RemoveSelectedMemberButton
            // 
            this.RemoveSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RemoveSelectedMemberButton.Location = new System.Drawing.Point(379, 461);
            this.RemoveSelectedMemberButton.Name = "RemoveSelectedMemberButton";
            this.RemoveSelectedMemberButton.Size = new System.Drawing.Size(270, 59);
            this.RemoveSelectedMemberButton.TabIndex = 34;
            this.RemoveSelectedMemberButton.Text = "Remove Selected";
            this.RemoveSelectedMemberButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedMemberButton.Click += new System.EventHandler(this.RemoveSelectedMemberButton_Click);
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 30;
            this.TeamMemberListBox.Location = new System.Drawing.Point(379, 121);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(270, 334);
            this.TeamMemberListBox.TabIndex = 33;
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(13, 185);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(333, 38);
            this.CreateMemberButton.TabIndex = 20;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // CellphoneValue
            // 
            this.CellphoneValue.Location = new System.Drawing.Point(149, 144);
            this.CellphoneValue.Name = "CellphoneValue";
            this.CellphoneValue.Size = new System.Drawing.Size(197, 35);
            this.CellphoneValue.TabIndex = 16;
            // 
            // AddNewMember
            // 
            this.AddNewMember.Controls.Add(this.CreateMemberButton);
            this.AddNewMember.Controls.Add(this.CellphoneValue);
            this.AddNewMember.Controls.Add(this.CellphoneLabel);
            this.AddNewMember.Controls.Add(this.EmailValue);
            this.AddNewMember.Controls.Add(this.EmailLabel);
            this.AddNewMember.Controls.Add(this.LastNameValue);
            this.AddNewMember.Controls.Add(this.LastNameLabel);
            this.AddNewMember.Controls.Add(this.FirstNameValue);
            this.AddNewMember.Controls.Add(this.FirstNameLabel);
            this.AddNewMember.Location = new System.Drawing.Point(21, 287);
            this.AddNewMember.Name = "AddNewMember";
            this.AddNewMember.Size = new System.Drawing.Size(352, 233);
            this.AddNewMember.TabIndex = 32;
            this.AddNewMember.TabStop = false;
            this.AddNewMember.Text = "Add New Member";
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CellphoneLabel.Location = new System.Drawing.Point(6, 142);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(138, 37);
            this.CellphoneLabel.TabIndex = 15;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(149, 107);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(197, 35);
            this.EmailValue.TabIndex = 14;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(6, 105);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 37);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(149, 70);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(197, 35);
            this.LastNameValue.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(6, 68);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(149, 33);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(197, 35);
            this.FirstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 31);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddMemberButton.Location = new System.Drawing.Point(129, 243);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(136, 38);
            this.AddMemberButton.TabIndex = 31;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // SelectMemberDropDown
            // 
            this.SelectMemberDropDown.FormattingEnabled = true;
            this.SelectMemberDropDown.Location = new System.Drawing.Point(21, 199);
            this.SelectMemberDropDown.Name = "SelectMemberDropDown";
            this.SelectMemberDropDown.Size = new System.Drawing.Size(352, 38);
            this.SelectMemberDropDown.TabIndex = 30;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(213, 50);
            this.HeaderLabel.TabIndex = 26;
            this.HeaderLabel.Text = "Create Team";
            // 
            // SelectMemberLabel
            // 
            this.SelectMemberLabel.AutoSize = true;
            this.SelectMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectMemberLabel.Location = new System.Drawing.Point(14, 159);
            this.SelectMemberLabel.Name = "SelectMemberLabel";
            this.SelectMemberLabel.Size = new System.Drawing.Size(194, 37);
            this.SelectMemberLabel.TabIndex = 29;
            this.SelectMemberLabel.Text = "Select Member";
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(21, 121);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(352, 35);
            this.TeamNameValue.TabIndex = 28;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(14, 81);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 27;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 596);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.RemoveSelectedMemberButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.AddNewMember);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectMemberDropDown);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.SelectMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.AddNewMember.ResumeLayout(false);
            this.AddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Button RemoveSelectedMemberButton;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox CellphoneValue;
        private System.Windows.Forms.GroupBox AddNewMember;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.ComboBox SelectMemberDropDown;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label SelectMemberLabel;
        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
    }
}
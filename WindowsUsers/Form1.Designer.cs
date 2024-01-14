namespace WindowsUsers
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
            this.panelSide = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.chkNeverExpires = new System.Windows.Forms.CheckBox();
            this.chkCannotChange = new System.Windows.Forms.CheckBox();
            this.chkMustChanged = new System.Windows.Forms.CheckBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblName = new System.Windows.Forms.Label();
            this.btnStatus = new FontAwesome.Sharp.IconButton();
            this.btnLocal = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelSide.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSide.Controls.Add(this.iconButton1);
            this.panelSide.Controls.Add(this.panelUsers);
            this.panelSide.Controls.Add(this.panelAddUser);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(261, 756);
            this.panelSide.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Silver;
            this.iconButton1.IconSize = 100;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(246, 78);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Windows Users";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelUsers
            // 
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsers.Location = new System.Drawing.Point(3, 87);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(258, 239);
            this.panelUsers.TabIndex = 2;
            this.panelUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsers_Paint);
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.chkDisabled);
            this.panelAddUser.Controls.Add(this.chkNeverExpires);
            this.panelAddUser.Controls.Add(this.chkCannotChange);
            this.panelAddUser.Controls.Add(this.chkMustChanged);
            this.panelAddUser.Controls.Add(this.iconButton3);
            this.panelAddUser.Controls.Add(this.txtPassword);
            this.panelAddUser.Controls.Add(this.label4);
            this.panelAddUser.Controls.Add(this.txtUserName);
            this.panelAddUser.Controls.Add(this.label3);
            this.panelAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddUser.Location = new System.Drawing.Point(3, 332);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(258, 360);
            this.panelAddUser.TabIndex = 3;
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkDisabled.Location = new System.Drawing.Point(14, 267);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(218, 29);
            this.chkDisabled.TabIndex = 8;
            this.chkDisabled.Text = "Account is disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // chkNeverExpires
            // 
            this.chkNeverExpires.AutoSize = true;
            this.chkNeverExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNeverExpires.Location = new System.Drawing.Point(14, 232);
            this.chkNeverExpires.Name = "chkNeverExpires";
            this.chkNeverExpires.Size = new System.Drawing.Size(215, 29);
            this.chkNeverExpires.TabIndex = 7;
            this.chkNeverExpires.Text = "Pass never expires";
            this.chkNeverExpires.UseVisualStyleBackColor = true;
            this.chkNeverExpires.CheckedChanged += new System.EventHandler(this.chkNeverExpires_CheckedChanged);
            // 
            // chkCannotChange
            // 
            this.chkCannotChange.AutoSize = true;
            this.chkCannotChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCannotChange.Location = new System.Drawing.Point(14, 197);
            this.chkCannotChange.Name = "chkCannotChange";
            this.chkCannotChange.Size = new System.Drawing.Size(229, 29);
            this.chkCannotChange.TabIndex = 6;
            this.chkCannotChange.Text = "Cannot change pass";
            this.chkCannotChange.UseVisualStyleBackColor = true;
            this.chkCannotChange.CheckedChanged += new System.EventHandler(this.chkCannotChange_CheckedChanged);
            // 
            // chkMustChanged
            // 
            this.chkMustChanged.AutoSize = true;
            this.chkMustChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMustChanged.Location = new System.Drawing.Point(14, 162);
            this.chkMustChanged.Name = "chkMustChanged";
            this.chkMustChanged.Size = new System.Drawing.Size(201, 29);
            this.chkMustChanged.TabIndex = 5;
            this.chkMustChanged.Text = "MustChangePass";
            this.chkMustChanged.UseVisualStyleBackColor = true;
            this.chkMustChanged.CheckedChanged += new System.EventHandler(this.chkMust_CheckedChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton3.ForeColor = System.Drawing.Color.PaleGreen;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton3.IconColor = System.Drawing.Color.PaleGreen;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(124, 324);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(119, 34);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Create";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(14, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 31);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserName.Location = new System.Drawing.Point(14, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(229, 31);
            this.txtUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(996, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(47, 32);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(290, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 26);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // btnStatus
            // 
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStatus.ForeColor = System.Drawing.Color.Green;
            this.btnStatus.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnStatus.IconColor = System.Drawing.Color.Green;
            this.btnStatus.IconSize = 20;
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(295, 75);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Rotation = 0D;
            this.btnStatus.Size = new System.Drawing.Size(165, 34);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "OK";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnLocal
            // 
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLocal.ForeColor = System.Drawing.Color.DimGray;
            this.btnLocal.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLocal.IconColor = System.Drawing.Color.DimGray;
            this.btnLocal.IconSize = 20;
            this.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.Location = new System.Drawing.Point(466, 75);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Rotation = 0D;
            this.btnLocal.Size = new System.Drawing.Size(161, 34);
            this.btnLocal.TabIndex = 4;
            this.btnLocal.Text = "Global";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(259, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 2);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(275, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Caption:";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSID.ForeColor = System.Drawing.Color.Gray;
            this.lblSID.Location = new System.Drawing.Point(275, 400);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(46, 25);
            this.lblSID.TabIndex = 8;
            this.lblSID.Text = "SID";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(407, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(306, 84);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "N/A";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.Location = new System.Drawing.Point(387, 238);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(47, 25);
            this.lblCaption.TabIndex = 10;
            this.lblCaption.Text = "N/A";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Crimson;
            this.btnDelete.IconSize = 20;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(918, 710);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(111, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(265, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(763, 602);
            this.listBox1.TabIndex = 12;
            this.listBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 756);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSide.ResumeLayout(false);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSide;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lblName;
        private FontAwesome.Sharp.IconButton btnStatus;
        private FontAwesome.Sharp.IconButton btnLocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.CheckBox chkMustChanged;
        private System.Windows.Forms.CheckBox chkCannotChange;
        private System.Windows.Forms.CheckBox chkNeverExpires;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.ListBox listBox1;
    }
}


using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var name = ((Button)sender).Text;
            var search = new ManagementObjectSearcher($"Select * from Win32_UserAccount where Name='{name}'");
            foreach (var user in search.Get())
            {
                lblName.Text = user["Name"].ToString();
                lblCaption.Text = user["Caption"].ToString();
                lblDescription.Text = user["Description"].ToString();
                lblSID.Text = user["SID"].ToString();

                btnStatus.Text = user["Status"].ToString();
                if(btnStatus.Text == "OK")
                {
                    btnStatus.ForeColor = Color.MediumSeaGreen;
                    btnStatus.IconColor = Color.MediumSeaGreen;
                    btnStatus.IconChar = IconChar.CheckCircle;
                }
                else
                {
                    btnStatus.ForeColor = Color.Crimson;
                    btnStatus.IconColor = Color.Crimson;
                    btnStatus.IconChar = IconChar.TimesCircle;
                }

                if((bool)user["LocalAccount"])
                {
                    btnLocal.Text = "Local";
                    btnLocal.IconChar = IconChar.DoorClosed;
                }
                else
                {
                    btnLocal.Text = "Global";
                    btnLocal.IconChar = IconChar.DoorOpen;
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var context = new PrincipalContext(ContextType.Machine,Environment.MachineName);

            var user = new UserPrincipal(context);
            user.Name = txtUserName.Text;
            user.SetPassword(txtPassword.Text);
            user.PasswordNeverExpires = chkNeverExpires.Checked;
            user.UserCannotChangePassword = chkCannotChange.Checked;
            if (chkMustChanged.Checked)
            {
                user.ExpirePasswordNow();
            }
            user.Enabled = !chkDisabled.Checked;
            user.Save();

            var group = GroupPrincipal.FindByIdentity(context, "Users");
            group.Members.Add(user);
            user.Save();

            GetAllUsers();
            panelUsers.Visible = true;
        }

        private void GetAllUsers()
        {
            panelUsers.Controls.Clear();

            var search = new ManagementObjectSearcher("Select * from Win32_UserAccount");
            foreach (var user in search.Get())
            {
                var button = new IconButton()
                {
                    Text = user["Name"].ToString(),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleLeft,

                    IconChar = IconChar.Circle,
                    IconColor = Color.White,
                    ImageAlign = ContentAlignment.MiddleLeft,

                    TextImageRelation = TextImageRelation.ImageBeforeText,

                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },

                    Width = panelSide.Width,
                    Height = 60,
                    Dock = DockStyle.Top

                };
                button.Click += Button_Click;
                panelUsers.Controls.Add(button);
            }
            var btn = new IconButton()
            {
                IconChar = IconChar.PlusCircle,
                IconSize = 30,
                IconColor = Color.White,
                ImageAlign = ContentAlignment.MiddleCenter,

                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Width = panelSide.Width,
                Height = 60,
                Dock = DockStyle.Top
            };
            btn.Click += Btn_Click;
            panelSide.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            panelUsers.Visible = false;
            GetAllUserGroups();
            listBox1.Visible = true;
        }

        private void GetAllUserGroups()
        {
            var context = new PrincipalContext(ContextType.Machine, Environment.MachineName);
            var group = new GroupPrincipal(context);
            foreach (var item in group.GetGroups())
            {
                listBox1.Items.Add(item.Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var localDir = new DirectoryEntry($"WinNT://{Environment.MachineName}");
            var users = localDir.Children;
            var user = users.Find(lblName.Text);
            if (user.Name == Environment.UserName) return;

            var result = MessageBox.Show("This action is irreversible. Continue?","Warning",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            users.Remove(user);

            ((IconButton)panelUsers.Controls[0]).PerformClick();

            GetAllUsers();
        }

        private void chkMust_CheckedChanged(object sender, EventArgs e)
        {
            chkCannotChange.Enabled = !chkMustChanged.Checked;
            chkNeverExpires.Enabled = !chkMustChanged.Checked;
        }

        private void chkCannotChange_CheckedChanged(object sender, EventArgs e)
        {
            chkMustChanged.Checked = !chkCannotChange.Enabled && !chkNeverExpires.Checked;
        }

        private void chkNeverExpires_CheckedChanged(object sender, EventArgs e)
        {
            chkNeverExpires.Enabled = !chkCannotChange.Enabled && !chkNeverExpires.Checked;
        }

        private void panelUsers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

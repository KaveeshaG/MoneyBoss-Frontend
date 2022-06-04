using System.Windows.Forms;

namespace MonyBoss.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void backLoginLbl_Click(object sender, System.EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, System.EventArgs e)
        {
            new mainScrn().Show();
            this.Hide();
        }
    }
}
namespace rpgProjetoForms
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void registrarBt_Click(object sender, EventArgs e)
        {
            RegistrarMenu registrar = new RegistrarMenu();
            this.Hide();
            registrar.Show();
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}

namespace TrocaValores
{
    public partial class Form1 : Form
    {   
        public Form1()
        {   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aux = TxtValor2.Text;
            TxtValor2.Text = TxtValor1.Text;
            TxtValor1.Text = aux;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClick.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClick.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClick.FlatStyle = FlatStyle.Flat;
            btnClick.Image = TrocaValores.Properties.Resources.trocar;
        }

        private void btnClick_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
        }
    }
}
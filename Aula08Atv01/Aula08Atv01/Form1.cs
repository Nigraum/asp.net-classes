namespace Aula08Atv01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SomarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(Numero1TextBox.Text);
            int numero2 = Convert.ToInt32(Numero2TextBox.Text);
            int resposta = numero1 + numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

        private void SubtrairButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(Numero1TextBox.Text);
            int numero2 = Convert.ToInt32(Numero2TextBox.Text);
            int resposta = numero1 - numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(Numero1TextBox.Text);
            int numero2 = Convert.ToInt32(Numero2TextBox.Text);
            int resposta = numero1 * numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(Numero1TextBox.Text);
            int numero2 = Convert.ToInt32(Numero2TextBox.Text);
            double resposta = numero1 / numero2;

            RespostaLabel.Text = Convert.ToString(resposta);
        }
    }
}
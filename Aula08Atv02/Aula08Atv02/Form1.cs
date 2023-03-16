namespace Aula08Atv02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            tabuadaListBox1.Items.Clear();

            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);
            for (int i = 1; i <= 10; i++)
            {
                string linha = string.Format("{0} x {1} = {2}", tabuada, i, i * tabuada);
                tabuadaListBox1.Items.Add(linha);
            }
        }
    }
}
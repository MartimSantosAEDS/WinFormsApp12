namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void corETipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog COR = new ColorDialog();
            if (COR.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = COR.Color;
            }
            FontDialog letra = new FontDialog();
            if (letra.ShowDialog() == DialogResult.OK)
            {
                label1.Font = letra.Font;
            }

        }

    }
}

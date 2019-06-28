using Base_Converter.Properties;
using System;
using System.Windows.Forms;

namespace Base_Converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Icon = Resources.Unicorn_Icon;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            Text = Settings.Default.FormText;
        }

        private void BtnToBase2_Click(object sender, EventArgs e)
        {
            Form form = new Base10ToBase2();
            form.Show();
        }

        private void BtnToBase10_1_Click(object sender, EventArgs e)
        {
            Form form = new Base2ToBase10();
            form.Show();
        }

        private void BtnToHex2_Click(object sender, EventArgs e)
        {
            Form form = new Base10ToHex();
            form.Show();
        }

        private void BtnToBase10_3_Click(object sender, EventArgs e)
        {
            Form form = new HexToBase10();
            form.Show();
        }
    }
}

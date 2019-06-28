using Base_Converter.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Base_Converter
{
    public partial class BaseForm : Form
    {
        public BaseForm()
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

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string value = txbValue.Text;
                   
            string result = ToConvert(value);
            txbResult.Text = result;
        }

        protected virtual string ToConvert(string value)
        {
            throw new NotImplementedException();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //if (DesignMode)
            //    return;

            lblTextLeft.Text = ValueText;
            lblTextRight.Text = ResultText;
        }

        protected virtual string ValueText
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected virtual string ResultText
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private void TxbValue_Enter(object sender, EventArgs e)
        {
            txbValue.BackColor = Color.Beige;
        }

        private void TxbValue_Leave(object sender, EventArgs e)
        {
            txbValue.BackColor = Color.White;
        }
    }
}

using Base_Converter.Properties;
using System;

namespace Base_Converter
{
    public partial class HexToBase10 : BaseForm
    {
        public HexToBase10()
        {
            InitializeComponent();
        }
        protected override string ToConvert(string value)
        {
            return Convert.ToInt32(value, 16).ToString();
        }

        protected override string ValueText
        {
            get
            {
                return "16진수";
            }
        }

        protected override string ResultText
        {
            get
            {
                return "10진수";
            }
        }
    }
}

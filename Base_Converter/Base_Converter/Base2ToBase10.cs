using Base_Converter.Properties;
using System;

namespace Base_Converter
{
    public partial class Base2ToBase10 : BaseForm
    {
        public Base2ToBase10()
        {
            InitializeComponent();
        }

        protected override string ToConvert(string value)
        {
            return Convert.ToInt32(value, 2).ToString();
        }

        protected override string ValueText
        {
            get
            {
                return "2진수";
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

using Base_Converter.Properties;
using System;

namespace Base_Converter
{
    public partial class Base10ToBase2 : BaseForm
    { 
        public Base10ToBase2()
        {
            InitializeComponent();
        }

        protected override string ToConvert(string value)
        {
            return Convert.ToString(Int32.Parse(value), 2);
        }

        protected override string ValueText
        {
            get
            {
                return "10진수";
            }
        }

        protected override string ResultText
        {
            get
            {
                return "2진수";
            }
        }
    }
}

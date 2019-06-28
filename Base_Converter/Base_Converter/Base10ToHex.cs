using Base_Converter.Properties;
using System;

namespace Base_Converter
{
    public partial class Base10ToHex : BaseForm
    {
        public Base10ToHex()
        {
            InitializeComponent();
        }

        protected override string ToConvert(string value)
        {
            return Int32.Parse(value).ToString("X8");
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
                return "16진수";
            }
        }
    }
}

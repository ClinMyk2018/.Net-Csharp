using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4.T2Class.ClinardMykal
{
    class TextBox
    {
        public String Text;

        public TextBox()
        {
            Text = "";
        }
        public TextBox(string Text)
        {
            Text = Text;
        }
        public void SetText(string newText)
        {
            Text = newText;
        }
    }

}

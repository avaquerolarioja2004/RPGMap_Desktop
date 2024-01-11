using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    class Utilities
    {
        private PrivateFontCollection privateFont = new PrivateFontCollection();
        private Font fontButton;
        private Font fontTittle;
        private Font fontTittleVecna;
        private Font fontText;
        private Font fontButtonMini;

        public Utilities()
        {
            privateFont.AddFontFile("res\\font\\AnyConv.com__Vecna (1).ttf");
            privateFont.AddFontFile("res\\font\\AnyConv.com__DRAGON HUNTER (1).ttf");
            fontButton = new Font(privateFont.Families[1], 36);
            fontTittle = new Font(privateFont.Families[0], 92);
            fontTittleVecna = new Font(privateFont.Families[1], 48);
            fontText = new Font(privateFont.Families[1], 24);
            fontButtonMini = new Font(privateFont.Families[1], 26);
        }

        public Font getFontBtt()
        {
            return fontButton;
        }
        public Font getFontLbTittle()
        {
            return fontTittle;
        }
        public Font getFontLbTittleVecna()
        {
            return fontTittleVecna;
        }
        public Font getFontLbText()
        {
            return fontText;
        }

        public Font getFontBttMini()
        {
            return fontButtonMini;
        }

    }
}

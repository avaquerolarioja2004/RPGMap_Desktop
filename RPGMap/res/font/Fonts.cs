using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    class Fonts
    {
        private PrivateFontCollection privateFont = new PrivateFontCollection();
        private Font fontButton;
        private Font fontTittle;
        private Font fontTittleVecna;
        private Font fontText;
        private Font fontButtonMini;
        private Font fontButtonSelectCont;
        private Font fontBttRoomPicker;
        private Font fontLbRoomPicker;

        public Fonts()
        {
            privateFont.AddFontFile("res\\font\\AnyConv.com__Vecna (1).ttf");
            privateFont.AddFontFile("res\\font\\AnyConv.com__DRAGON HUNTER (1).ttf");
            fontButton = new Font(privateFont.Families[1], 36);
            fontTittle = new Font(privateFont.Families[0], 92);
            fontTittleVecna = new Font(privateFont.Families[1], 48);
            fontText = new Font(privateFont.Families[1], 24);
            fontButtonMini = new Font(privateFont.Families[1], 26);
            fontButtonSelectCont = new Font(privateFont.Families[1], 14);
            fontBttRoomPicker= new Font(privateFont.Families[1], 12);
            fontLbRoomPicker = new Font(privateFont.Families[1], 14);
        }

        public Font getFontLbRoomPicker()
        {
            return fontLbRoomPicker;
        }

        public Font getFontBttRoomPicker()
        {
            return fontBttRoomPicker;
        }

        public Font getFontBttContent()
        {
            return fontButtonSelectCont;
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

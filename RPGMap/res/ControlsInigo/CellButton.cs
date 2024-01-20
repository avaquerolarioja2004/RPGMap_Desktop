using System.Windows.Forms;

namespace CustomControls.Controls
{
    internal class CellButton : Button
    {
        public int X { get; }
        public int Y { get; }

        public CellButton(int x, int y)
        {
            SetStyle(ControlStyles.Selectable, false);
            X = x;
            Y = y;
        }
    }
}

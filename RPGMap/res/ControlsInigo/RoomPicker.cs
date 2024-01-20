using RPGMap;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public partial class RoomPicker : UserControl
    {
        private const int size = 10;
        private Fonts f;

        public Color UnSelected { get; set; }
        public Color Selected { get; set; }
        public Action<int, int> OnSubmit { get; set; }

        private int x, y;

        public RoomPicker()
        {
            InitializeComponent();
            f = new Fonts();
            UnSelected = Color.White;
            Selected = Color.LightSkyBlue;
            x = y = 0;
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new CellButton(i+1, j+1)
                    {
                        BackColor = UnSelected,
                        FlatStyle = FlatStyle.Flat,
                        Margin = Padding.Empty,
                        Dock = DockStyle.Fill,
                    };

                    button.FlatAppearance.BorderColor = Color.DarkGray;
                    button.FlatAppearance.BorderSize = 2;

                    button.Click += (s, e) => {
                        CellButton b = (CellButton) s;

                        PaintCells(UnSelected, 0, x, 0, y);

                        x = Math.Max(1, Math.Min(b.X, size));
                        y = Math.Max(1, Math.Min(b.Y, size));

                        valueX.Text = x.ToString();
                        valueY.Text = y.ToString();

                        PaintCells(Selected, 0, x, 0, y);
                    };

                    table.Controls.Add(button, i, j);
                }
            }

            clear_btn.Click += (s, e) => {
                PaintCells(UnSelected, 0, x, 0, y);
                valueX.Text = valueY.Text = "0";
                x = y = 0;
            };

            submit_btn.Click += (s, e) => {
                if(x + y > 0)
                {
                    OnSubmit?.Invoke(x, y);
                }
                else
                {
                    MessageBox.Show("Selecciona un tamaño para la sala", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void RoomPicker_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.None;
            this.clear_btn.Font = f.getFontBttRoomPicker();
            this.submit_btn.Font = f.getFontBttRoomPicker();
            
            this.clear_btn.BackgroundImage= RPGMap.Properties.Resources.rectangle_mini_mini_mini;
            this.submit_btn.BackgroundImage = RPGMap.Properties.Resources.rectangle_mini_mini_mini;
            
            this.labelY.Font = f.getFontLbRoomPicker();
            this.valueY.Font = f.getFontLbRoomPicker();
            this.labelX.Font = f.getFontLbRoomPicker();
            this.valueX.Font = f.getFontLbRoomPicker();
            
        }

        private void PaintCells(Color color, int x1, int x2, int y1, int y2)
        {
            for(int i = x1; i < x2; i++)
            {
                for(int j = y1; j < y2; j++)
                {
                    table.GetControlFromPosition(i, j).BackColor = color;
                }
            }
        }
    }
}

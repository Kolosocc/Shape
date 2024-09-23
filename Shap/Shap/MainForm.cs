using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shap
{
    public partial class MainForm : Form
    {
        private ShapeFactory currentFactory;
        private string selectedShape = "Circle";

        public MainForm()
        {
            InitializeComponent();
            currentFactory = new RedFactory();
        }

        private void OnFactoryChanged(object sender, EventArgs e)
        {
            string selectedColor = colorComboBox.SelectedItem.ToString();
            currentFactory = selectedColor == "Red" ? new RedFactory() : new BlueFactory();
        }

        private void OnDrawButtonClicked(object sender, EventArgs e)
        {
            drawPanel.Invalidate();
            drawPanel.Paint += OnDrawPanelPaint;
        }

        private void OnDrawPanelPaint(object sender, PaintEventArgs e)
        {
            int size = (int)sizeSelector.Value;
            int x = (int)xCoordinateSelector.Value;
            int y = (int)yCoordinateSelector.Value;

            Shape shape = selectedShape switch
            {
                "Circle" => currentFactory.CreateCircle(size),
                "Square" => currentFactory.CreateSquare(size),
                "Triangle" => currentFactory.CreateTriangle(size),
                _ => null,
            };

            shape?.Draw(e.Graphics, x, y);
        }
    }
}

namespace Shap
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.sizeSelector = new System.Windows.Forms.NumericUpDown();
            this.xCoordinateSelector = new System.Windows.Forms.NumericUpDown();
            this.yCoordinateSelector = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();

            // Labels
            var colorLabel = new System.Windows.Forms.Label();
            var shapeLabel = new System.Windows.Forms.Label();
            var sizeLabel = new System.Windows.Forms.Label();
            var xLabel = new System.Windows.Forms.Label();
            var yLabel = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.sizeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateSelector)).BeginInit();
            this.SuspendLayout();

            // colorComboBox
            this.colorComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorComboBox.Items.AddRange(new object[] { "Red", "Blue" });
            this.colorComboBox.SelectedIndex = 0;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.OnFactoryChanged);

            // shapeComboBox
            this.shapeComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeComboBox.Items.AddRange(new object[] { "Circle", "Square", "Triangle" });
            this.shapeComboBox.SelectedIndex = 0;
            this.shapeComboBox.SelectedIndexChanged += new System.EventHandler((s, e) => selectedShape = shapeComboBox.SelectedItem.ToString());

            // sizeSelector
            this.sizeSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizeSelector.Minimum = 10;
            this.sizeSelector.Maximum = 200;
            this.sizeSelector.Value = 50;

            // xCoordinateSelector
            this.xCoordinateSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.xCoordinateSelector.Minimum = 0;
            this.xCoordinateSelector.Maximum = 500;
            this.xCoordinateSelector.Value = 100;

            // yCoordinateSelector
            this.yCoordinateSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.yCoordinateSelector.Minimum = 0;
            this.yCoordinateSelector.Maximum = 400;
            this.yCoordinateSelector.Value = 100;

            // drawButton
            this.drawButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawButton.Text = "Draw Shape";
            this.drawButton.BackColor = System.Drawing.Color.LightBlue;
            this.drawButton.Click += new System.EventHandler(this.OnDrawButtonClicked);

            // drawPanel
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.BackColor = System.Drawing.Color.White;

            // Labels
            colorLabel.Text = "Select Color:";
            shapeLabel.Text = "Select Shape:";
            sizeLabel.Text = "Size:";
            xLabel.Text = "X Coordinate:";
            yLabel.Text = "Y Coordinate:";

            // Set Dock for labels
            colorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            shapeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            sizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            xLabel.Dock = System.Windows.Forms.DockStyle.Top;
            yLabel.Dock = System.Windows.Forms.DockStyle.Top;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.yCoordinateSelector);
            this.Controls.Add(yLabel);
            this.Controls.Add(this.xCoordinateSelector);
            this.Controls.Add(xLabel);
            this.Controls.Add(this.sizeSelector);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.shapeComboBox);
            this.Controls.Add(shapeLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(colorLabel);
            this.Text = "Shape Drawing Application";

            ((System.ComponentModel.ISupportInitialize)(this.sizeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCoordinateSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCoordinateSelector)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.NumericUpDown sizeSelector;
        private System.Windows.Forms.NumericUpDown xCoordinateSelector;
        private System.Windows.Forms.NumericUpDown yCoordinateSelector;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel drawPanel;
    }
}

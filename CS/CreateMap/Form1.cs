using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace CreateMap {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a map control.
            MapControl map = new MapControl();

            // Specify the map position on the form           
            map.Dock = DockStyle.Fill;

            // Create a layer.
            ImageLayer layer = new ImageLayer();
            map.Layers.Add(layer);

            // Create a data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            layer.DataProvider = provider;

            // Specify the map zoom level and center point 
            map.ZoomLevel = 2;
            map.CenterPoint = new GeoPoint(38, -100);

            // Add the map control to the window.
            this.Controls.Add(map);
        }
    }
}

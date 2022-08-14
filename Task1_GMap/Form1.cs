using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace Task1_GMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DB db = new DB();
            db.openConnection();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
         
            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true;
           gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MarkersEnabled = true;
             gMapControl1.MaxZoom = 18;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Zoom = 10;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;

             GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);

            // Создаём новый список маркеров
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            // Инициализация красного маркера с указанием его коордиант
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(66.4169575018027, 94.25025752215694), GMarkerGoogleType.red);
            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);

            // Текст отображаемый с маркером
            marker.ToolTipText = "Software Technologies";
            // Добавляем маркер в список маркеров
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

        }
    }
}

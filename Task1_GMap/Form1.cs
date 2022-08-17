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

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Position = new PointLatLng(66.4169575018027, 94.25025752215694);
            gMapControl1.ShowCenter = false;

        }
//сделать 
        public class Us 
        {
            Us us = new Us();
        }
        private GMarkerGoogle GetMarker(Us us, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.red)
        {
            GMarkerGoogle mapMarker = new GMarkerGoogle(new PointLatLng(us.сordx, us.сordy), gMarkerGoogleType);
            mapMarker.ToolTip = new GMapRoundedToolTip(mapMarker);
            mapMarker.ToolTipText = us.id;
            mapMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            return mapMarker;
        }
        private GMapOverlay GetOverlayMarkers(List<Us> uss, string name, GMarkerGoogleType gMarkerGoogleType = GMarkerGoogleType.red)
        {
            GMapOverlay gMapMarkers = new GMapOverlay(name);
            foreach (Us us in uss)
            {
                gMapMarkers.Markers.Add(GetMarker(us, gMarkerGoogleType));// добавление маркеров на слой
            }
            return gMapMarkers;

        }
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e) // оставила, чтобы потом сделать перенос маркера по клику
        {
            Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
        }
    }
}

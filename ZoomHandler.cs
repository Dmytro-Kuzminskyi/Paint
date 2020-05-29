using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Paint
{
    [ToolStripItemDesignerAvailability
     (ToolStripItemDesignerAvailability.ToolStrip |
        ToolStripItemDesignerAvailability.StatusStrip)]
    public class TrackBarItem : ToolStripControlHost
    {
        public TrackBarItem() : base(new TrackBar()) { }

        public TrackBar Initialize()
        {
            return Control as TrackBar;
        }
    }
    public partial class MainForm
	{
        private static readonly int[] zoomLevel = { 25, 50, 75, 100, 200, 300, 400 };
        private float zoomFactor;

        public static float GetZoomFactor(TrackBar ztb)
        {
            var zlstr = zoomLevel[ztb.Value].ToString();
            return float.Parse(zlstr.Length == 2 ? "0." + zlstr : zlstr.Substring(0, 1));
        }
        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            var currentValue = zoomTrackBar.Value;
            if (currentValue < zoomTrackBar.Maximum)
                zoomTrackBar.Value += 1;
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            var currentValue = zoomTrackBar.Value;
            if (currentValue > zoomTrackBar.Minimum)
                zoomTrackBar.Value -= 1;
        }

        private void ZoomLevel_Changed(object sender, EventArgs e)
        {
            var s = sender as TrackBar;
            zoomLevelLabel.Text = zoomLevel[s.Value] + "%";
            zoomFactor = GetZoomFactor(s);
            /*
            layer.Width = (int)(layer.CanvasWidth * zoomFactor);
            layer.Height = (int)(layer.CanvasHeight * zoomFactor);
            layer.Invalidate();*/
        }
    }
}

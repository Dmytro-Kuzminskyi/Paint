using System.Windows.Forms;

namespace Paint
{
    public class Layer : Panel
    {
        public Layer()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}

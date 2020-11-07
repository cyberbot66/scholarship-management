using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ScholarshipManagement.Controls
{
    class CirclePictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grath = new GraphicsPath();
            grath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grath);
            base.OnPaint(pe);
        }
    }
}

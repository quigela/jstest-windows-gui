using System.Drawing;
using System.Windows.Forms;

namespace jstest_windows_gui
{
    class TriggerProgressBar : ProgressBar
    {
        public TriggerProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Minimum = 0;
            this.Maximum = 255;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle full_rec = e.ClipRectangle;
            Rectangle rec = full_rec;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum));
            //if (ProgressBarRenderer.IsSupported)
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height;
            e.Graphics.FillRectangle(Brushes.Blue, 0, 0, rec.Width, rec.Height);
            e.Graphics.DrawString(this.Value.ToString(), new Font(this.Font, FontStyle.Regular), Brushes.White, (full_rec.Width / 2), (full_rec.Height - 20));
        }
    }
}

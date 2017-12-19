using System.Windows.Forms;

namespace ReCLI
{
    public class SmoothSplitContainer : SplitContainer
    {
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            this.IsSplitterFixed = true;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            this.IsSplitterFixed = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            if (this.IsSplitterFixed)
            {
                if (e.Button.Equals(MouseButtons.Left))
                {
                    if (this.Orientation.Equals(Orientation.Vertical))
                    {
                        if (e.X > 0 && e.X < this.Width)
                        {
                            this.SplitterDistance = e.X;
                            this.Refresh();
                        }
                    }
                    else
                    {
                        if (e.Y > 0 && e.Y < this.Height)
                        {
                            this.SplitterDistance = e.Y;
                            this.Refresh();
                        }
                    }
                }
                else
                {
                    this.IsSplitterFixed = false;
                }
            }
            base.OnMouseMove(e);
        }
    }
}

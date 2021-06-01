using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Feedback_Application
{
    class MyTransparentTrackBar : TrackBar
    {
        protected override void OnCreateControl()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            if (Parent != null)
                BackColor = Parent.BackColor;

            base.OnCreateControl();
        }
    }
}

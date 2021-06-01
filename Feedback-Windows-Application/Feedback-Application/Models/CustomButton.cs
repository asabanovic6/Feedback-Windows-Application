using System;
using System.Collections.Generic;
using System.Text;

namespace Feedback_Application.Models
{
    class CustomButton : MetroFramework.Controls.MetroButton
    {
        public CustomButton() : base() { }
        public bool Clicked {get; set;}

    }
}

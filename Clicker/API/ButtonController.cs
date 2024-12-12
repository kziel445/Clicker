using Clicker.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Clicker.API
{
    internal class ButtonController
    {
        // Get_Cursor_Position 
        public static void Get_Cursor_Position_OnClick(Label label)
        {
            LabelController.ShowInLabel(label, ShowPointerPosition.MousePosition().ToString());
        }

    }
}

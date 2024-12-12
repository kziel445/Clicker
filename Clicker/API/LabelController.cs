using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Clicker.API
{
    internal class LabelController
    {
        public static void ShowInLabel(System.Windows.Controls.Label label, string text)
        {
            label.Content = text;
        }
    }
}

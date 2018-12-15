using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyLibrary.Helpers
{
    public static class Grid
    {

        public static bool LoadUniqueModule<T>(System.Windows.Controls.Grid grid) where T : UIElement, new()
        {
            if (grid.Children.Count != 0)
            {
                if (grid.Children.OfType<UIElement>().First() is T)
                {
                    return false;
                }
            }

            grid.Children.Clear();
            grid.Children.Add(new T());

            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace KDHY.DW.CsCtl.Behaviors
{
    public class MaxBehavior : Behavior<UIElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            if (this.AssociatedObject is Button btn)
            {
                btn.Click += Btn_Click;
            }
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            if (this.AssociatedObject is Button btn)
            {
                btn.Click -= Btn_Click;
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var w = Window.GetWindow(this.AssociatedObject);
            if (w.WindowState == WindowState.Maximized)
                w.WindowState = WindowState.Normal;
            else
                w.WindowState = WindowState.Maximized;
        }

    }
}

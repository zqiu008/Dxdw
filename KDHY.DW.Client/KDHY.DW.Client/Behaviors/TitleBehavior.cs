using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace KDHY.DW.Client.Behaviors
{
    public class TitleBehavior : Behavior<UIElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.MouseLeftButtonDown += AssociatedObject_MouseLeftButtonDown;
            if (this.AssociatedObject is Button btn)
            {
                btn.MouseDoubleClick += Btn_MouseDoubleClick;
            }
        }

        private void Btn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var w = Window.GetWindow(this.AssociatedObject);
            if (w != null)
            {
                if (w.WindowState == WindowState.Maximized)
                    w.WindowState = WindowState.Normal;
                else
                    w.WindowState = WindowState.Maximized;
            }
        }

        private void AssociatedObject_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           var w=Window.GetWindow(this.AssociatedObject);
            if (w != null)
                w.DragMove();
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.MouseLeftButtonDown -= AssociatedObject_MouseLeftButtonDown;
            if (this.AssociatedObject is Button btn)
            {
                btn.MouseDoubleClick -= Btn_MouseDoubleClick;
            }
        }
    }
}

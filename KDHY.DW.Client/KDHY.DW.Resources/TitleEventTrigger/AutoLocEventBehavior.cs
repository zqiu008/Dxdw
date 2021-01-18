using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace KDHY.DW.Resources
{
    public class AutoLocEventBehavior : TargetedTriggerAction<UserControl>
    {
        protected override void Invoke(object parameter)
        {
            if (this.Target != null)
            {
                foreach (Window win in Application.Current.Windows)
                {
                    if (win.Name.Equals("HostWindow"))
                    {
                        UserControl userControl = UIElementUtil.FindChild<UserControl>(win, this.TargetName);
                        if (this.TargetName.Equals("ReceiveDataControl"))
                        {
                            dynamic receiveDataControl = userControl;
                            receiveDataControl.CheckFunctionCompleted();
                        }
                        if (this.TargetName.Equals("RetestControl"))
                        {
                            dynamic retestControl = userControl;
                            retestControl.CheckFunctionCompleted();
                        }
                    }
                }
            }
        }
    }
}

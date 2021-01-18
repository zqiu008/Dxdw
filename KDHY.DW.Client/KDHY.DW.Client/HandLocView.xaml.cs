using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KDHY.DW.Client
{
    /// <summary>
    /// HandLocView.xaml 的交互逻辑
    /// </summary>
    public partial class HandLocView : UserControl
    {
        public ObservableCollection<ExpandoObject> LocMesList { set; get; } = new ObservableCollection<ExpandoObject>();
        public HandLocView()
        {
            InitializeComponent();

            DataContext = this;
            for (int i = 0; i < 10; i++)
            {
                LocMesModel mes = new LocMesModel { 
                    DisplayName=$"卫星{i+1}定位",
                    LocResault1= "纬度30.3958°，经度109.8889°",
                    LocResault2= "纬度30.3958°，经度109.8889°",
                    LocTime= "2017-05-16 18:46:09:913",
                    LocTitle= "2017-05-16 18:46:09:913",
                    LocUtc= "2017-05-16 18:46:09:913",
                    SatLatLon= "纬度30.3958°，经度109.8889°"
                };
                var o=JsonConvert.DeserializeObject<ExpandoObject>(JsonConvert.SerializeObject(mes));
                LocMesList.Add(o);
            }
        }

        private void CalendarClock_SelectedDateTimeChanged(object sender, HandyControl.Data.FunctionEventArgs<DateTime?> e)
        {

        }

        private void Date_Click(object sender, RoutedEventArgs e)
        {
            if (CalendarClock.Visibility == Visibility.Visible)
                CalendarClock.Visibility = Visibility.Hidden;
            else
                CalendarClock.Visibility = Visibility.Visible;
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using Memory;

namespace Gujian3Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        //private Mem MemLib => Helper.MemLib;
        private RoleProperty _RoleProperty = new RoleProperty();
        public RoleProperty RoleProperty 
        {
            get => _RoleProperty;
            set
            {
                _RoleProperty = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoleProperty)));
            }
        } 

        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Helper.Initial("Gujian3.CT","Gujian3.exe");
            Task.Run(() => helperTaskFunc());
        }
        private void helperTaskFunc()
        {
            while (true)
            {
                Thread.Sleep(300);
                
                if (!Helper.IsGameOpen())
                {
                    this.Dispatcher.Invoke(() => IsEnabled = false);
                    continue;
                }
                if (!Helper.OpenProcess()) continue;
                this.Dispatcher.Invoke(() => IsEnabled = true);
                this.Dispatcher.Invoke(() => ReadWriteParamWord());
            }
        }
        private void ReadWriteParamWord()
        {
            if (rabRead.IsChecked.Value)
            {
                propGrid.IsEnabled = false;
                chkLockParam.IsEnabled = false;
                chkLockParam.IsChecked = false;
                RoleProperty = Helper.ReadPropertyFromGame<RoleProperty>();
                this.Dispatcher.Invoke(() => propGrid.Update());
            }
            else
            {
                propGrid.IsEnabled = true;
                chkLockParam.IsEnabled = true;
                if (chkLockParam.IsChecked.Value)
                {
                    propGrid.IsEnabled = false;
                    Helper.WritePropertyFromGame(RoleProperty);
                }
                else
                {
                    propGrid.IsEnabled = true;
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Helper.CloseProcess();
        }
    }
}

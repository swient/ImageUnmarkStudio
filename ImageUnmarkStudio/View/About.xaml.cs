using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace ImageUnmarkStudio
{
    public partial class AboutWindow : HandyControl.Controls.Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void swient_Click(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/swient",
                UseShellExecute = true
            });
        }

        private void Famouseegg_Click(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/famouseegg",
                UseShellExecute = true
            });
        }

        private void Pinshao_Click(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/pinshao",
                UseShellExecute = true
            });
        }

        private void Project_Link_Click(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/swient/ImageUnmarkStudio",
                UseShellExecute = true
            });
        }
    }
}

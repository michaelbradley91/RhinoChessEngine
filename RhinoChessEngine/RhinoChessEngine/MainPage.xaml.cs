using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RhinoChessEngine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AppPanel_LayoutUpdated(object sender, object e)
        {
            ChessBoard.Width = Math.Min(AppPanel.ActualWidth, AppPanel.ActualHeight);
            ChessBoard.Height = Math.Min(AppPanel.ActualWidth, AppPanel.ActualHeight);
        }
    }
}

using Avalonia.Controls;
using AvaloniaCounterExample.ViewModels;

namespace AvaloniaCounterExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(CounterViewModel viewModel) : this()
        {
            this.DataContext = viewModel;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

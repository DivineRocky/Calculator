using Services.Calculators;
using Services.Factories;
using Shared.Enums;
using Shared.Extension;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseCalculator baseCalculator;

        public MainWindow()
        {
            baseCalculator = new BaseCalculator(new CalculateOperationFactory());
            InitializeComponent();
            CalculateButton.Click += CalcluateClick;
        }

        private void CalcluateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = baseCalculator.Calculate(decimal.Parse(FirstNumber.Text), decimal.Parse(FirstNumber.Text), Operation.Text.ToEnum<Operation>());
                Thread.Sleep(2000);
                this.ResultLabel.Content = $"Result = {result}";
            }
            catch (System.Exception ex)
            {
                MessageBoxResult result = MessageBox.Show(ex.Message);
            }    
        }
    }
}

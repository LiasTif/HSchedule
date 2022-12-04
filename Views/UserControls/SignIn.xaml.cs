using System.Windows.Controls;

namespace HSchedule.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void PassTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            PassTextBox2.Focus();
        }

        private void PassTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            PassTextBox3.Focus();
        }

        private void PassTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            PassTextBox4.Focus();
        }
    }
}

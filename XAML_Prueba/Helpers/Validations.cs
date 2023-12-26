using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace XAML_Prueba.Helpers
{
    public class Validations
    {

        public void TextBox_PreviewTextInputNumbers(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !AreAllValidNumericChars(((TextBox)sender).Text + e.Text);
        }

        public bool AreAllValidNumericChars(string str)
        {
            return int.TryParse(str, out _);
        }

        public void TextBox_PreviewTextInputString(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !AreAllValidChars(e.Text);
        }

        public bool AreAllValidChars(string str)
        {
            return !str.Any(char.IsDigit);
        }
    }
}

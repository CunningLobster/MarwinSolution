using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Marwin.UI.Validation
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Проверить наличие символов в тексте контрола
        /// </summary>
        /// <param name="control">Контрол</param>
        public static void CheckToEmptyString(Control control, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(control, "Поле не может быть пустым"); ;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(control, "");
            }
        }

        /// <summary>
        /// Проверить длину строки текста контрола
        /// </summary>
        /// <param name="control">Контрол</param>
        /// <param name="length">Длина строки</param>
        public static void CheckStringLength(Control control, int length, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (control.Text.Length < 1)
                return;

            if (control.Text.Length > length)
            {
                e.Cancel = true;
                errorProvider.SetError(control, $"Длина строки не может превышать {length} символов");
            }
            else 
            {
                e.Cancel = false;
                errorProvider.SetError(control, "");
            }
        }
    }
}

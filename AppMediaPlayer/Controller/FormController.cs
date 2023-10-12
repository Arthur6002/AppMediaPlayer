using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer.Controller
{
    public class FormController
    {
        static Form actual_page = null;
        public static void ShowForm(Form actual,Form page)
        {
            CloseForm(actual);
            actual_page = page;
            page.Show();
        }

        public static void CloseForm(Form actual)
        {
            actual.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SportItems.Classes
{
    public static class NavClass
    {

        public static Frame frame;

        public static Dictionary<string,Page> PagesDictionary = SetPages();

        private static Dictionary<string, Page> SetPages() =>
            new()
            {
                {"MainWindowPage",new Pages.MainWindowPage()},
                {"SignInPage",new Pages.SignInPage()},
                {"SignUpPage",new Pages.SignUpPage()},
                {"ItemAddPage",new Pages.ItemAddPage()},
                {"AdminProfilePage",new Pages.AdminProfilePage()}
            };

    }
}

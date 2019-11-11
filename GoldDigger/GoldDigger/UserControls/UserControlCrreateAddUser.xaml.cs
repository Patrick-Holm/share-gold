using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BIZ;


namespace GoldDigger
{
    /// <summary>
    /// Interaction logic for UserControlCrreateAddUser.xaml
    /// 
    ///  Ejer Patrick Holm Wedel Olsen AKA Patwix
    ///  
    /// 
    /// 
    /// </summary>
    public partial class UserControlCrreateAddUser : UserControl
    {
        // ClassCustomer CC; 
        ClassBiz Biz;
        Grid SubGridMetalPrice;
        Grid SubGridCustomer;

        public UserControlCrreateAddUser(ClassBiz inBiz, Grid inSubGridMetalPrice, Grid inSubGridCustomer)
        {
            InitializeComponent();
            Biz = inBiz;
            // cc = new ClassCustomer();
            GridUserMain.DataContext = Biz;
            SubGridCustomer = inSubGridCustomer;
            SubGridMetalPrice = inSubGridCustomer;
        }

        private void buttonUCCAUCancelNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)Parent).Children.Remove(this);
            SubGridMetalPrice.IsEnabled = true;
            // Needs Fallback Call
        }

        private void buttonUCCUANewCustomer_Click(object sender, RoutedEventArgs e)
        {
            ((Grid)Parent).Children.Remove(this);
            SubGridMetalPrice.IsEnabled = true;
            
        }
    }
}

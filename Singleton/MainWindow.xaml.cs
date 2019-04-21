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
using Singleton.Classes;

namespace Singleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WorkingFramWork _WorkingFramWork1 =  WorkingFramWork.Instance();
            _WorkingFramWork1.Name = ".NET Framework [WEB]";
            _WorkingFramWork1.Color = new SolidColorBrush(Colors.Red);
            AddInList("1.0. [First] WorkingFramWork's name is: ", _WorkingFramWork1);

            WorkingFramWork _WorkingFramWork1Clone = (WorkingFramWork)_WorkingFramWork1.Clone();

            WorkingFramWork _WorkingFramWork2 = WorkingFramWork.Instance();
            AddInList("2.0. [Second] WorkingFramWork's name is: ", _WorkingFramWork2);

            WorkingFramWork _WorkingFramWork3 = WorkingFramWork.Instance();
            _WorkingFramWork3.Name = "Windows Azure";
            _WorkingFramWork3.Color = new SolidColorBrush(Colors.Green);
            AddInList("3.0. [Third, Name Changed] WorkingFramWork's name is: ", _WorkingFramWork3);

            WorkingFramWork _WorkingFramWork3New = _WorkingFramWork3;

            WorkingFramWork _WorkingFramWork4 = WorkingFramWork.Instance();
            AddInList("4.0. [Forth] WorkingFramWork's name is: ", _WorkingFramWork4);

            AddInList("1.0. [First again] WorkingFramWork's name is ", _WorkingFramWork1);
            AddInList("1.5. [Previous clone of First] WorkingFramWork's name is: ", _WorkingFramWork1Clone);


            WorkingFramWork _WorkingFramWork5 = WorkingFramWork.Instance();
            _WorkingFramWork5.Name = ".NET Framework [Desktop]";
            _WorkingFramWork5.Color = new SolidColorBrush(Colors.Blue);
            AddInList("5.0. [Fifth, Again Changed] WorkingFramWork's name is: ", _WorkingFramWork5);

            WorkingFramWork _WorkingFramWork6 = WorkingFramWork.Instance();
            AddInList("6.0. [Sixth] WorkingFramWork's name is: ", _WorkingFramWork6);

            AddInList("1.5. [Previous clone of First] WorkingFramWork's name is: ", _WorkingFramWork1Clone); 
            AddInList("1.0. [First again] WorkingFramWork's name is ", _WorkingFramWork1);
            AddInList("3.0. [Third again] WorkingFramWork's name is ", _WorkingFramWork3);
            AddInList("3.5. [Third New] WorkingFramWork's name is ", _WorkingFramWork3New);

            _WorkingFramWork1Clone.Name = "Androied";
            _WorkingFramWork1Clone.Color = new SolidColorBrush(Colors.Orange);
            AddInList("1.5. [Previous clone of First Modified] WorkingFramWork's name is: ", _WorkingFramWork1Clone);

            AddInList("1.0. [First again] WorkingFramWork's name is ", _WorkingFramWork1);
        }

        private void AddInList(string _Details, WorkingFramWork _Obj)
        {
            ListBoxItem li = new ListBoxItem();
            li.Content = _Details + _Obj.Name;
            li.Foreground = _Obj.Color;
            lstList.Items.Add(li);
        }
    }
}

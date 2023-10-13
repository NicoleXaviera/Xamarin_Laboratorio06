using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            //ObservableCollection allows to be added after ItemsSource
            //is set and the UI will react to changes
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Xaviera Ugarriza" });
            employees.Add(new Employee { DisplayName = "Gonzalo Lazo de la Vega" });
            employees.Add(new Employee { DisplayName = "Jacko Tinoco" });
            employees.Add(new Employee { DisplayName = "Fildel Matos" });
            employees.Add(new Employee { DisplayName = "Pierina Barco" });
        }
    }
}
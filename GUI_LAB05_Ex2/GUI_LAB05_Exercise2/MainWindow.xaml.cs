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
using AgentAssignment;

namespace GUI_LAB05_Exercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Agent> AgentList = new List<Agent>();
        public MainWindow()
        {
            InitializeComponent();
            AgentList.Add(new Agent("007", "James Bond", "Terror", "AntiTerror"));
            AgentList.Add(new Agent("001", "James Bind", "Terror", "AntiTerror"));
            ListName.ItemsSource = AgentList;
            GridName.DataContext = AgentList;
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (ListName.SelectedIndex < ListName.Items.Count - 1)
            {
                ListName.SelectedIndex++;
            }
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            if (ListName.SelectedIndex > 0)
                ListName.SelectedIndex--;
        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            AgentList.Add(new Agent("","","",""));
            ListName.Items.Refresh();
            ListName.SelectedIndex = ListName.Items.Count - 1;
        }
    }
}

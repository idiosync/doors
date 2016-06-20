using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stageLanes = new Dictionary<int, jfetting.cDoor>();
            initializeDoors();


        }


        protected void initializeDoors()
        {
            //Check to see if I already have the door information from the config file for now I'll always pull from the database

            createDoors();

        }

        protected void createDoors()
        {
            for(int x=117; x < 136; x++){
                jfetting.cDoor lane = new jfetting.cDoor();
                lane.Margin = new Thickness(5);
                //lane.Height = 120;
                //lane.Width = 360;
                lane.door = "Door " + (x+1);
                doorPanel.Children.Add(lane);
                stageLanes.Add(x, lane);
            }    
        }

        protected Dictionary<Int32, jfetting.cDoor> stageLanes;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("TODO Implement Config Settings");
        }
    }
}

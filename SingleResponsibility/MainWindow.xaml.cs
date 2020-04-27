using SingleResponsibility.Enums;
using SingleResponsibility.Logic;
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
using SingleResponsibility.Houses;
using SingleResponsibility.Models;

namespace SingleResponsibility
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string,House> houses = new Dictionary<string, House>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!IsValid())
                return;

            HouseBuilder house = GetHouseBuilder();

            Builder builder = new Builder();
            builder.Construct(house);

            if (!houses.ContainsKey(txtName.Text))
            {
                houses.Add(txtName.Text, house.House);
                lstHouses.Items.Add(txtName.Text);                
            }
            else
            {
                MessageBox.Show("Such house exists !", "Error");
            }

            txtMain.Text = Visualizer.Visualize(house.House);
        }

        private void lstHouses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox list  = (ListBox)(e.Source);

            txtMain.Text = Visualizer.Visualize(houses[list.SelectedItem.ToString()]);
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter name", "Error!");
                return false;
            }
            else if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please choose type", "Error!");
                return false;
            }
            else if (cmbStyle.SelectedItem == null)
            {
                MessageBox.Show("Please choose style", "Error!");
                return false;
            }

            return true;
        }

        private HouseBuilder GetHouseBuilder()
        {
            switch ((HouseType)cmbType.SelectedItem)
            {
                case HouseType.Counryside:
                    return new CountrysideHouse(txtName.Text, (int)upDownRooms.Value, (Styles)cmbStyle.SelectedItem);
                case HouseType.Oceanside:
                    return new OceansideHouse(txtName.Text, (int)upDownRooms.Value, (Styles)cmbStyle.SelectedItem);

                default:
                    return new KingHouse(txtName.Text, (int)upDownRooms.Value, (Styles)cmbStyle.SelectedItem);
            }
        }
    }
}
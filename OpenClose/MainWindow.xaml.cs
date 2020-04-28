using OpenClose.Enums;
using OpenClose.Factory;
using OpenClose.Interfaces;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace OpenClose
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IPizza pizza;
        private PizzaType pizzaType;
        private List<Extras> extrasList;
        private IPizzaFactory pizza_factory;
        private List<IPizza> PizzaList;

        public MainWindow()
        {
            InitializeComponent();
            pizza_factory = new OrdinaryPizzaFactory();
        }

        private void PepperoniPizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = PizzaType.Pepperoni;

            ResetUI();

            UpdatePizzaUI();

        }

        private void RejermedtunPizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = PizzaType.Tuna;

            ResetUI();

            UpdatePizzaUI();

        }

        private void SkinkePizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = PizzaType.Ham;

            ResetUI();

            UpdatePizzaUI();

        }

        private void KebabPizzaGroupBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            pizzaType = PizzaType.Kebab;

            ResetUI();

            UpdatePizzaUI();

        }

        private void PepperoniExtraCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            extrasList.Add(Extras.Pepper);

            UpdatePizzaUI();
        }

        private void PepperoniExtraCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            extrasList.Remove(Extras.Pepper);

            UpdatePizzaUI();
        }

        private void CheeseExtraCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            extrasList.Add(Extras.Cheese);

            UpdatePizzaUI();
        }

        private void CheeseExtraCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            extrasList.Remove(Extras.Cheese);

            UpdatePizzaUI();
        }

        private void FamilyPizzaCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            extrasList.Add(Extras.Family);

            UpdatePizzaUI();

        }

        private void FamilyPizzaCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            extrasList.Remove(Extras.Family);

            UpdatePizzaUI();

        }

        private void AddPizzaButton_Click(object sender, RoutedEventArgs e)
        {
            if (PizzaList == null)
            {
                PizzaList = new List<IPizza>();
            }

            PizzaList.Add(pizza);

            pizzaType = PizzaType.Default;
            pizza = null;

            ResetUI();

            UpdatePizzaUI();

        }

        private void UpdatePizzaUI()
        {
            if (pizzaType != PizzaType.Default)
            {

                pizza = pizza_factory.MakePizza(extrasList, pizzaType);


                PriceLabel.Content = string.Format("{0}$", pizza.Price);
                CaloriesLabel.Content = pizza.Calories + " cal";

                ExtrasGroupBox.Visibility = Visibility.Visible;
            }

            if (PizzaList != null)
            {
                string pizza_label = "Cart \n";
                double total_price = 0;
                double total_calories = 0;

                foreach (IPizza pizza in PizzaList)
                {
                    pizza_label += string.Format("{0} \n", pizza.Name);

                    total_price += pizza.Price;

                    total_calories += pizza.Calories;
                }

                PizzaListLabel.Content = pizza_label;

                PriceTotalLabel.Content = string.Format("{0}$", total_price);
                CaloriesTotalLabel.Content = total_calories + " cal";
            }
        }

        private void ResetUI()
        {
            extrasList = new List<Extras>();

            PriceLabel.Content = "0 $";
            CaloriesLabel.Content = "0 cal";

            PepperoniExtraCheckbox.IsChecked = false;
            CheeseExtraCheckbox.IsChecked = false;
            FamilyPizzaCheckbox.IsChecked = false;
        }

    }
}

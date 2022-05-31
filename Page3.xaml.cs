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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Kursova
{
    
    public partial class Page3 : Page
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable StaffingTable;
        public Page3()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
        }

        private void page1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void page2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
        private void insert_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Insert());
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Fond";
            StaffingTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(StaffingTable);
                staffingGrid.ItemsSource = StaffingTable.DefaultView;

                string sql2 = "SELECT DISTINCT Name_departmen FROM Fond";
                SqlCommand command2 = new SqlCommand(sql2, connection);

                SqlDataReader read = command2.ExecuteReader(); //Считываем и извлекаем данные
                Box.Items.Add("All");
                while (read.Read()) //Читаем пока есть данные
                {
                    Box.Items.Add(read.GetValue(0).ToString()); //Добавляем данные в лист итем
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string sqlList = Box.SelectedItem.ToString();
            StaffingTable = new DataTable();
            SqlConnection connection = null;
            string sql = "SELECT * FROM Fond";
            string sql2 = "SELECT * FROM Fond WHERE Name_departmen = ('" + sqlList + "')";
            if (sqlList == "All")
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
            }
            else
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql2, connection);
                adapter = new SqlDataAdapter(command);
            }
            connection.Open();
            adapter.Fill(StaffingTable);
            staffingGrid.ItemsSource = StaffingTable.DefaultView;
        }
       
    }
}

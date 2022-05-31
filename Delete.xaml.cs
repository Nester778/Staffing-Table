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
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace Kursova
{
    /// <summary>
    /// Логика взаимодействия для Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        SqlDataAdapter adapter;
        DataTable StaffingTable;
        public Delete()
        {
            InitializeComponent();
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Insert());
        }

        private void Updata_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Updata());
        }
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (DelBox.Text != "")
            {
                str = DelBox.SelectedItem.ToString();
                String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("DELETE  from Fond where Id_fond = ('" + DelBox.Text + "')", con);
                SqlCommand cmd1 = new SqlCommand("DELETE  from Prizes where Id_Prize = ('" + DelBox.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("DELETE  from Position where Id_Positon = ('" + DelBox.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Элемент с Id '" + DelBox.Text + "' Удален.");

                string sql = "SELECT * FROM Position";
                StaffingTable = new DataTable();
                SqlConnection connection = null;
                try
                {
                    string connectionString1 = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                    connection = new SqlConnection(connectionString1);
                    SqlCommand command = new SqlCommand(sql, connection);
                    adapter = new SqlDataAdapter(command);

                    connection.Open();
                    adapter.Fill(StaffingTable);
                    DelBox.ItemsSource = StaffingTable.DefaultView;


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
        }
        string str;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT * FROM Position";
            StaffingTable = new DataTable();
            SqlConnection connection = null;
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(StaffingTable);
                DelBox.ItemsSource = StaffingTable.DefaultView;

                
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
        private void DelBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

    }

}

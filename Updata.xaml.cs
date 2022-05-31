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
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Kursova
{
    /// <summary>
    /// Логика взаимодействия для Updata.xaml
    /// </summary>
    public partial class Updata : Page
    {
        public Updata()
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
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Delete());
        }
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        private void Id_Positon_TextChanged(object sender, TextChangedEventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmdPo1 = new SqlCommand("SELECT Id_Positon from Position where Id_Positon = ('" + Box.Text + "')", con);
            if (Box.Text.Length > 0)
            {
                con.Open();
                Id_Positon.Text = cmdPo1.ExecuteScalar().ToString();
                con.Close();
            }
            else 
            {
                Id_Positon.Text = "";
            }
        }
        private void Name_departmen_TextChanged(object sender, TextChangedEventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);


            if (Name_departmen.Text.Length > 0 && Box.Text.Length > 0)
            {

                con.Open();
                string sqlList = Box.SelectedItem.ToString();
                SqlCommand cmdPo2 = new SqlCommand("SELECT Name_departmen from Position where Id_Positon = ('" + Box.Text + "')", con);


                Regex reg = new Regex(@"^[А-Я]{1}([а-я]{1})*$");
                Regex reg1 = new Regex(@"^[А-Я]{1}");
                Regex reg4 = new Regex(@"^[а-я]{1}");
                Regex reg2 = new Regex(@"^[A-Z]{1}([a-z]{1})*$");
                Regex reg3 = new Regex(@"^[A-Z]{1}");
                Regex reg5 = new Regex(@"^[a-z]{1}");
                if (reg4.IsMatch(Name_departmen.Text))
                {
                    Name_departmen.Text = cmdPo2.ExecuteScalar().ToString();
                    MessageBox.Show("Строка введина не коректно.");
                }
                if (reg1.IsMatch(Name_departmen.Text))
                {
                    if (!reg.IsMatch(Name_departmen.Text))
                    {
                        Name_departmen.Text = cmdPo2.ExecuteScalar().ToString();
                        MessageBox.Show("Строка введина не коректно.");
                    }
                }
                if (reg5.IsMatch(Name_departmen.Text))
                {
                    Name_departmen.Text = cmdPo2.ExecuteScalar().ToString();
                    MessageBox.Show("Строка введина не коректно.");
                }
                if (reg3.IsMatch(Name_departmen.Text))
                {
                    if (!reg2.IsMatch(Name_departmen.Text))
                    {
                        Name_departmen.Text = cmdPo2.ExecuteScalar().ToString();
                        MessageBox.Show("Строка введина не коректно.");
                    }
                }
            }
            else 
            {
                Name_departmen.Text = "";
            }
            con.Close();
        }
        private void Profesion_TextChanged(object sender, TextChangedEventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            

            if (Profesion.Text.Length > 0 && Box.Text.Length > 0)
            {
                string sqlList = Box.SelectedItem.ToString();
                con.Open();
                SqlCommand cmdPo2 = new SqlCommand("SELECT Profesion from Position where Id_Positon = ('" + Box.Text + "')", con);


                Regex reg = new Regex(@"^[А-Я]{1}([а-я]{1})*$");
                Regex reg1 = new Regex(@"^[А-Я]{1}");
                Regex reg4 = new Regex(@"^[а-я]{1}");
                Regex reg2 = new Regex(@"^[A-Z]{1}([a-z]{1})*$");
                Regex reg3 = new Regex(@"^[A-Z]{1}");
                Regex reg5 = new Regex(@"^[a-z]{1}");
                if (reg4.IsMatch(Name_departmen.Text))
                {
                    Profesion.Text = cmdPo2.ExecuteScalar().ToString();
                    MessageBox.Show("Строка введина не коректно.");
                }
                if (reg1.IsMatch(Profesion.Text))
                {
                    if (!reg.IsMatch(Profesion.Text))
                    {
                        Profesion.Text = cmdPo2.ExecuteScalar().ToString();
                        MessageBox.Show("Строка введина не коректно.");
                    }
                }
                if (reg5.IsMatch(Profesion.Text))
                {
                    Profesion.Text = cmdPo2.ExecuteScalar().ToString();
                    MessageBox.Show("Строка введина не коректно.");
                }
                if (reg3.IsMatch(Profesion.Text))
                {
                    if (!reg2.IsMatch(Profesion.Text))
                    {
                        Profesion.Text = cmdPo2.ExecuteScalar().ToString();
                        MessageBox.Show("Строка введина не коректно.");
                    }
                }
            }
            else 
            {
                Profesion.Text = "";
            }
            con.Close();
        }
        private void Number_emp_TextChanged(object sender, TextChangedEventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            if (Number_emp.Text.Length > 0 && Box.Text.Length > 0)
            {
                string sqlList = Box.SelectedItem.ToString();
                con.Open();
                SqlCommand cmdPo2 = new SqlCommand("SELECT Number_emp from Position where Id_Positon = ('" + Box.Text + "')", con);

                Regex reg = new Regex(@"^([0-9]{1})*$");
                if (!reg.IsMatch(Number_emp.Text))
                {
                    Number_emp.Text = cmdPo2.ExecuteScalar().ToString();
                    MessageBox.Show("Строка введина не коректно.");
                }
                con.Close();
            }
            else 
            {
                Number_emp.Text = "";
            }
        }
///-------------------------------------------------------------------------------------------------------
        private void Harmful_conditions_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Harmful_conditions.Text = "0";
            else
            {
                String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmdPo2 = new SqlCommand("SELECT Harmful_conditions from Prizes where Id_Prize = ('" + Box.Text + "')", con);


                if (Harmful_conditions.Text.Length > 0 && Box.Text.Length > 0)
                {
                    con.Open();


                    Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
                    Regex reg2 = new Regex(@"^([0-9]{1})*$");
                    if (!reg.IsMatch(Harmful_conditions.Text))
                    {
                        if (!reg2.IsMatch(Harmful_conditions.Text))
                        {
                            Harmful_conditions.Text = cmdPo2.ExecuteScalar().ToString();
                            MessageBox.Show("Строка введина не коректно.");
                        }
                    }
                    if (Harmful_conditions.Text != "0" && Harmful_conditions.Text.Length != 0)
                    {
                        if (Prize.Text.Length == 0)
                            Prize.Text = Harmful_conditions.Text;
                        else {
                            if (!reg2.IsMatch(Harmful_conditions.Text))
                            {
                                Prize.Text = "";
                            }
                            else
                                Prize.Text = (double.Parse(Prize.Text) + double.Parse(Harmful_conditions.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                else
                {
                    Harmful_conditions.Text = "";
                }
            }
        }
        private void Military_accounting_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Military_accounting.Text = "0";
            else 
            { 
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

                if (Military_accounting.Text.Length > 0 && Box.Text.Length > 0)
                {
                    con.Open();
                    SqlCommand cmdPo2 = new SqlCommand("SELECT Military_accounting from Prizes where Id_Prize = ('" + Box.Text + "')", con);

                    Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
                    Regex reg2 = new Regex(@"^([0-9]{1})*$");
                    if (!reg.IsMatch(Military_accounting.Text))
                    {
                        if (!reg2.IsMatch(Military_accounting.Text))
                        {
                            Military_accounting.Text = cmdPo2.ExecuteScalar().ToString();
                            MessageBox.Show("Строка введина не коректно.");
                        }
                    }
                    if (Military_accounting.Text != "0" && Military_accounting.Text.Length != 0)
                    {
                        if (Prize.Text.Length == 0)
                            Prize.Text = Military_accounting.Text;
                        else
                            Prize.Text = (double.Parse(Prize.Text) + double.Parse(Military_accounting.Text)).ToString();
                    }
                    con.Close();
                }
                else 
                {
                    Military_accounting.Text = "";
                }
            }
        }

        private void Non_standard_working_day_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Non_standard_working_day.Text = "0";
            else
            {
                String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                if (Non_standard_working_day.Text.Length > 0 && Box.Text.Length > 0)
                {
                    con.Open();
                    SqlCommand cmdPo2 = new SqlCommand("SELECT Military_accounting from Prizes where Id_Prize = ('" + Box.Text + "')", con);

                    Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
                    Regex reg2 = new Regex(@"^([0-9]{1})*$");
                    if (!reg.IsMatch(Non_standard_working_day.Text))
                    {
                        if (!reg2.IsMatch(Non_standard_working_day.Text))
                        {
                            Non_standard_working_day.Text = cmdPo2.ExecuteScalar().ToString();
                            MessageBox.Show("Строка введина не коректно.");
                        }
                    }
                    if (Non_standard_working_day.Text != "0" && Non_standard_working_day.Text.Length != 0)
                    {
                        if (Prize.Text.Length == 0)
                            Prize.Text = Non_standard_working_day.Text;
                        else
                            Prize.Text = (double.Parse(Prize.Text) + double.Parse(Non_standard_working_day.Text)).ToString();
                    }
                    con.Close();
                }
                else
                {
                    Non_standard_working_day.Text = "";
                }
            }
        }

        private void Years_service_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Years_service.Text = "0";
            else
            {
                String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                if (Years_service.Text.Length > 0 && Box.Text.Length > 0)
                {
                    con.Open();
                    SqlCommand cmdPo2 = new SqlCommand("SELECT Years_service from Prizes where Id_Prize = ('" + Box.Text + "')", con);


                    Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
                    Regex reg2 = new Regex(@"^([0-9]{1})*$");
                    if (!reg.IsMatch(Years_service.Text))
                    {
                        if (!reg2.IsMatch(Years_service.Text))
                        {
                            Years_service.Text = cmdPo2.ExecuteScalar().ToString();
                            MessageBox.Show("Строка введина не коректно.");
                        }
                    }
                    if (Years_service.Text != "0" && Years_service.Text.Length != 0)
                    {
                        if (Prize.Text.Length == 0)
                            Prize.Text = Years_service.Text;
                        else
                            Prize.Text = (double.Parse(Prize.Text) + double.Parse(Years_service.Text)).ToString();
                    }
                    con.Close();
                }
                else 
                {
                    Years_service.Text = "";
                }
            }
        }
        private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmdPo2 = new SqlCommand("SELECT Salary from Fond where Id_fond = ('" + Box.Text + "')", con);
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Salary.Text = "0";
            else
            {
                con.Open();
                Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
                Regex reg2 = new Regex(@"^([0-9]{1})*$");
                if (!reg.IsMatch(Salary.Text))
                {
                    if (!reg2.IsMatch(Salary.Text))
                    {
                        Salary.Text = cmdPo2.ExecuteScalar().ToString();
                        MessageBox.Show("Строка введина не коректно.");
                    }
                }

                if (Number_emp.Text.Length == 0)
                    Salary.Text = cmdPo2.ExecuteScalar().ToString();
                else
                {
                    if (Salary.Text.Length == 0)
                        Salary.Text = "0";
                    Prize.Text = (double.Parse(Harmful_conditions.Text) + double.Parse(Military_accounting.Text) + double.Parse(Non_standard_working_day.Text) + double.Parse(Years_service.Text)).ToString();
                    Month_fond.Text = ((double.Parse(Prize.Text) + double.Parse(Salary.Text)) * int.Parse(Number_emp.Text)).ToString();
                }
                con.Close();
            }
        }
        private void Up_TextChanged(object sender, TextChangedEventArgs e)
        {
            var a = Id_Positon.Text;
            if (a.Length > 0)
                if (!Char.IsDigit(a[a.Length - 1]))
                    Id_Positon.Text = "";
        }
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (Box.Text.Length > 0)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmdF2 = new SqlCommand("SELECT Salary from Fond where Id_fond = ('" + Box.Text + "')", con);

                SqlCommand cmdPr1 = new SqlCommand("SELECT Harmful_conditions from Prizes where Id_Prize = ('" + Box.Text + "')", con);
                SqlCommand cmdPr2 = new SqlCommand("SELECT Military_accounting from Prizes where Id_Prize = ('" + Box.Text + "')", con);
                SqlCommand cmdPr3 = new SqlCommand("SELECT Non_standard_working_day from Prizes where Id_Prize = ('" + Box.Text + "')", con);
                SqlCommand cmdPr4 = new SqlCommand("SELECT Years_service from Prizes where Id_Prize = ('" + Box.Text + "')", con);

                SqlCommand cmdPo1 = new SqlCommand("SELECT Id_Positon from Position where Id_Positon = ('" + Box.Text + "')", con);
                SqlCommand cmdPo2 = new SqlCommand("SELECT Name_departmen from Position where Id_Positon = ('" + Box.Text + "')", con);
                SqlCommand cmdPo3 = new SqlCommand("SELECT Profesion from Position where Id_Positon = ('" + Box.Text + "')", con);
                SqlCommand cmdPo4 = new SqlCommand("SELECT Number_emp from Position where Id_Positon = ('" + Box.Text + "')", con);

                con.Open();
                Id_Positon.Text = cmdPo1.ExecuteScalar().ToString();
                Name_departmen.Text = cmdPo2.ExecuteScalar().ToString();
                Profesion.Text = cmdPo3.ExecuteScalar().ToString();
                Number_emp.Text = cmdPo4.ExecuteScalar().ToString();

                Harmful_conditions.Text = cmdPr1.ExecuteScalar().ToString();
                Military_accounting.Text = cmdPr2.ExecuteScalar().ToString();
                Non_standard_working_day.Text = cmdPr3.ExecuteScalar().ToString();
                Years_service.Text = cmdPr4.ExecuteScalar().ToString();

                Salary.Text = cmdF2.ExecuteScalar().ToString();
                Prize.Text = (double.Parse(Harmful_conditions.Text) + double.Parse(Military_accounting.Text) + double.Parse(Non_standard_working_day.Text) + double.Parse(Years_service.Text)).ToString();
                Month_fond.Text = ((double.Parse(Prize.Text) + double.Parse(Salary.Text)) * int.Parse(Number_emp.Text)).ToString();
                con.Close();
            }
        }

        private void Updata_Click(object sender, RoutedEventArgs e)
        {
            if (Name_departmen.Text.Length != 0 && Profesion.Text.Length != 0 && Number_emp.Text.Length != 0 && Harmful_conditions.Text.Length != 0 && Military_accounting.Text.Length != 0
               && Non_standard_working_day.Text.Length != 0 && Years_service.Text.Length != 0 && Salary.Text.Length != 0)
            {
                double Pr1 = double.Parse(Harmful_conditions.Text);
                double Pr2 = double.Parse(Military_accounting.Text);
                double Pr3 = double.Parse(Non_standard_working_day.Text);
                double Pr4 = double.Parse(Years_service.Text);
                double F2 = double.Parse(Salary.Text);

                String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("UPDATE Fond SET Salary = ('" + F2.ToString() + "'), Prize = ('" + Prize.Text + "'), Month_fond = ('" + Month_fond.Text + "') WHERE Id_fond=('" + Box.Text + "')", con);
                SqlCommand cmd1 = new SqlCommand("UPDATE Prizes SET Harmful_conditions = ('" + Pr1.ToString() + "'), Military_accounting = ('" + Pr2.ToString() + "'), Non_standard_working_day = ('" + Pr3.ToString() + "'), Years_service = ('" + Pr4.ToString() + "') WHERE Id_Prize=('" + Box.Text + "')", con);
                SqlCommand cmd2 = new SqlCommand("UPDATE Position SET Name_departmen = ('" + Name_departmen.Text + "'), Profesion = ('" + Profesion.Text + "'), Number_emp = ('" + Number_emp.Text + "') WHERE Id_Positon=('" + Box.Text + "')", con);

                con.Open();
                cmd2.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Изменения выполнены успешно.");
            }
        }
        SqlDataAdapter adapter;
        DataTable StaffingTable;
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
                Box.ItemsSource = StaffingTable.DefaultView;


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
        }

        
    }
}

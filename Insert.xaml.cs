using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Kursova
{
    [Table(Name = "Position")]
    public class Position
    {
        [Column(IsPrimaryKey = true)]
        public int Id_Positon { get; set; }
        [Column]
        public string Name_departmen { get; set; }
        [Column]
        public string Profesion { get; set; }
        [Column]
        public int Number_emp { get; set; }

    }
    [Table(Name = "Prizes")]
    public class Prizes
    {
        [Column(IsPrimaryKey = true)]
        public int Id_Prize { get; set; }
        [Column]
        public string Name_departmen { get; set; }
        [Column]
        public double Harmful_conditions { get; set; }
        [Column]
        public double Military_accounting { get; set; }
        [Column]
        public double Non_standard_working_day { get; set; }
        [Column]
        public double Years_service { get; set; }
    }
    [Table(Name = "Fond")]
    public class Fond
    {
        [Column(IsPrimaryKey = true)]
        public int Id_Fond { get; set; }
        [Column]
        public string Name_departmen { get; set; }
        [Column]
        public double Salary { get; set; }
        [Column]
        public double Prize { get; set; }
        [Column]
        public double Month_fond { get; set; }
    }

    public partial class Insert : Page
    {
        static string connectionString = @"Data Source=nester;Initial Catalog=StaffingTable;User ID=user1;Password=sa";
        public Insert()
        {
            InitializeComponent();
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT MAX(Id_Positon) FROM Position", con);
            con.Open();
            string a = cmd.ExecuteScalar().ToString();
            if (a.Length > 0)
            {
                int b = int.Parse(a) + 1;
                Id_Positon.Text = b.ToString();
            }
            else
                Id_Positon.Text = "1";
            con.Close();

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
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        //-------------------------------------------------------------------------------------        
        private void Updata_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Updata());
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Delete());

        }
        private void Id_Positon_TextChanged(object sender, TextChangedEventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT MAX(Id_Positon) FROM Position", con);
            con.Open();
            string a = cmd.ExecuteScalar().ToString();
            if (a.Length > 0)
            {
                int b = int.Parse(a) + 1;
                Id_Positon.Text = b.ToString();
            }
            else
                Id_Positon.Text = "1";
            con.Close();
        }
        private void Name_departmen_TextChanged(object sender, TextChangedEventArgs e)
        {

            Regex reg = new Regex(@"^[А-Я]{1}([а-я]{1})*$");
            Regex reg1 = new Regex(@"^[А-Я]{1}");
            Regex reg4 = new Regex(@"^[а-я]{1}");
            Regex reg2 = new Regex(@"^[A-Z]{1}([a-z]{1})*$");
            Regex reg3 = new Regex(@"^[A-Z]{1}");
            Regex reg5 = new Regex(@"^[a-z]{1}");
            Regex reg6 = new Regex(@"^[0-9]{1}");
            if (reg4.IsMatch(Name_departmen.Text))
            {
                Name_departmen.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
            if (reg6.IsMatch(Name_departmen.Text))
            {
                Name_departmen.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
            if (reg1.IsMatch(Name_departmen.Text))
            {
                if (!reg.IsMatch(Name_departmen.Text)) {
                    Name_departmen.Text = "";
                    MessageBox.Show("Строка введина не коректно."); 
                }
            }
            if (reg5.IsMatch(Name_departmen.Text))
            {
                Name_departmen.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
            if (reg3.IsMatch(Name_departmen.Text))
            {
                if (!reg2.IsMatch(Name_departmen.Text)) {
                    Name_departmen.Text = "";
                    MessageBox.Show("Строка введина не коректно."); 
                }
            }
            
        }
        private void Profesion_TextChanged(object sender, TextChangedEventArgs e)
        {

            Regex reg = new Regex(@"^[А-Я]{1}([а-я]{1})*$");
            Regex reg1 = new Regex(@"^[А-Я]{1}");
            Regex reg2 = new Regex(@"^[A-Z]{1}([a-z]{1})*$");
            Regex reg3 = new Regex(@"^[A-Z]{1}");
            Regex reg4 = new Regex(@"^[а-я]{1}");
            Regex reg5 = new Regex(@"^[a-z]{1}");
            Regex reg6 = new Regex(@"^[0-9]{1}");
            if (reg4.IsMatch(Profesion.Text))
            {
                Profesion.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
            if (reg6.IsMatch(Profesion.Text))
            {
                Profesion.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
            if (reg1.IsMatch(Profesion.Text))
            {
                if (!reg.IsMatch(Profesion.Text))
                {
                    Profesion.Text = "";
                    MessageBox.Show("Строка введина не коректно.");
                }
            }
            if (reg5.IsMatch(Profesion.Text))
            {
                Profesion.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
            if (reg3.IsMatch(Profesion.Text))
            {
                if (!reg2.IsMatch(Profesion.Text))
                {
                    Profesion.Text = "";
                    MessageBox.Show("Строка введина не коректно.");
                }
            }
        }

        private void Number_emp_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Years_service.Text = "0";

            Regex reg = new Regex(@"^([0-9]{1})*$");
            if (!reg.IsMatch(Number_emp.Text))
            {
                Number_emp.Text = "";
                MessageBox.Show("Строка введина не коректно.");
            }
        }
        //------------------------------------------------------------------------------------
        private void Harmful_conditions_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Harmful_conditions.Text = "0";

            Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
            Regex reg2 = new Regex(@"^([0-9]{1})*$");
            if (!reg.IsMatch(Harmful_conditions.Text))
            {
                if (!reg2.IsMatch(Harmful_conditions.Text))
                {
                    Harmful_conditions.Text = "";
                    MessageBox.Show("Строка введина не коректно.");
                }
            }


            if (Harmful_conditions.Text != "0" && Harmful_conditions.Text.Length != 0)
            {
                if (Prize.Text.Length == 0)
                    Prize.Text = Harmful_conditions.Text;
                else
                    Prize.Text = (double.Parse(Prize.Text) + double.Parse(Harmful_conditions.Text)).ToString();
            }
            else
                Harmful_conditions.Text = "0";
        }

        private void Military_accounting_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Military_accounting.Text = "0";

            Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
            Regex reg2 = new Regex(@"^([0-9]{1})*$");
            if (!reg.IsMatch(Military_accounting.Text))
            {
                if (!reg2.IsMatch(Military_accounting.Text))
                {
                    Military_accounting.Text = "";
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
            else
                Military_accounting.Text = "0";
        }

        private void Non_standard_working_day_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Non_standard_working_day.Text = "0";

            Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
            Regex reg2 = new Regex(@"^([0-9]{1})*$");
            if (!reg.IsMatch(Non_standard_working_day.Text))
            {
                if (!reg2.IsMatch(Non_standard_working_day.Text))
                {
                    Non_standard_working_day.Text = "";
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
            else
                Non_standard_working_day.Text = "0";
        }

        private void Years_service_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Id_Positon.Text.Length == 0 || Name_departmen.Text.Length == 0 || Profesion.Text.Length == 0 || Number_emp.Text.Length == 0)
                Years_service.Text = "0";

            Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
            Regex reg2 = new Regex(@"^([0-9]{1})*$");
            if (!reg.IsMatch(Years_service.Text))
            {
                if (!reg2.IsMatch(Years_service.Text))
                {
                    Years_service.Text = "";
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
            else
                Years_service.Text = "0";
        }
        //-----------------------------------------------------------------------------------
        private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (Id_Positon.Text.Length != 0 && Name_departmen.Text.Length != 0 && Profesion.Text.Length != 0 && Number_emp.Text.Length != 0)
            {

                Regex reg = new Regex(@"^([0-9]{1})*\,([0-9]{1})*$");
                Regex reg2 = new Regex(@"^([0-9]{1})*$");
                if (!reg.IsMatch(Salary.Text))
                {
                    if (!reg2.IsMatch(Salary.Text))
                    {
                        Salary.Text = "";
                        MessageBox.Show("Строка введина не коректно.");
                    }
                }

                if (Salary.Text.Length == 0)
                    Salary.Text = "0";
                Prize.Text = (double.Parse(Harmful_conditions.Text) + double.Parse(Military_accounting.Text) + double.Parse(Non_standard_working_day.Text) + double.Parse(Years_service.Text)).ToString();
                Month_fond.Text = ((double.Parse(Prize.Text) + double.Parse(Salary.Text)) * int.Parse(Number_emp.Text)).ToString();

            }
            else
            {
                Salary.Text = "";
            }
        }
        
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if (Name_departmen.Text.Length != 0 && Profesion.Text.Length != 0 && Number_emp.Text.Length != 0 && Harmful_conditions.Text.Length != 0 && Military_accounting.Text.Length != 0
               && Non_standard_working_day.Text.Length != 0 && Years_service.Text.Length != 0 && Salary.Text.Length != 0)
            {
                Position position = new Position
                {
                    Id_Positon = int.Parse(Id_Positon.Text),
                    Name_departmen = Name_departmen.Text,
                    Profesion = Profesion.Text,
                    Number_emp = int.Parse(Number_emp.Text)
                };

                Prizes prizes = new Prizes
                {
                    Id_Prize = int.Parse(Id_Positon.Text),
                    Name_departmen = Name_departmen.Text,
                    Harmful_conditions = double.Parse(Harmful_conditions.Text),
                    Military_accounting = double.Parse(Military_accounting.Text),
                    Non_standard_working_day = double.Parse(Non_standard_working_day.Text),
                    Years_service = double.Parse(Years_service.Text)
                };
                Fond fond = new Fond
                {
                    Id_Fond = int.Parse(Id_Positon.Text),
                    Name_departmen = Name_departmen.Text,
                    Salary = double.Parse(Salary.Text),
                    Prize = double.Parse(Prize.Text),
                    Month_fond = double.Parse(Month_fond.Text)
                };


                DataContext db = new DataContext(connectionString);
                db.GetTable<Position>().InsertOnSubmit(position);
                db.GetTable<Prizes>().InsertOnSubmit(prizes);
                db.GetTable<Fond>().InsertOnSubmit(fond);
                db.SubmitChanges();
                MessageBox.Show("Добавление выполнено успешно.");


                String connectionString1 = ConfigurationManager.ConnectionStrings["Kursova.Properties.Settings.StaffingTableConnectionString1"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString1);

                SqlCommand cmd = new SqlCommand("SELECT MAX(Id_Positon) FROM Position", con);
                con.Open();
                string a = cmd.ExecuteScalar().ToString();
                int b = int.Parse(a) + 1;
                Id_Positon.Text = b.ToString();
                con.Close();
            }
        }
    }
}

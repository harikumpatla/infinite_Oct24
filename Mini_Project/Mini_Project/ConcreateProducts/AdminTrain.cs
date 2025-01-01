using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.AbstractFactory;
using Mini_Project.Factories;
using System.Data;
using System.Data.SqlClient;

namespace Mini_Project.ConcreateProducts
{
    public class AdminTrain : IAdmin
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static IDataReader dr;

        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-D244D691;Initial Catalog=Railway_Reservation_System;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }
        public void AddTrains()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("=========Train Details=========");

                Console.WriteLine("Enter The Train Number :");
                int tNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The Train Name :  ");
                string tName = Console.ReadLine();

                Console.WriteLine("Enter The Sleeper Class Tickets :");
                int sTickets = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The Third Class Tickets :");
                int tTickets = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The Second Class Tickets :");
                int secTickets = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The First Class Tickets :");
                int fTickets = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The Source : ");
                string source = Console.ReadLine();

                Console.WriteLine("Enter The Destination :");
                string destination = Console.ReadLine();

                int Total_Berth = sTickets + tTickets + secTickets + fTickets;

                int Avaliable_Berth = Total_Berth;

                cmd = new SqlCommand("sp_addTrains", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@trainNumber", SqlDbType.Int)).Value = tNumber;
                cmd.Parameters.Add(new SqlParameter("@trainName", SqlDbType.VarChar)).Value = tName;
                cmd.Parameters.Add(new SqlParameter("@sleeper", SqlDbType.Int)).Value = sTickets;
                cmd.Parameters.Add(new SqlParameter("@3rdClass", SqlDbType.Int)).Value = tTickets;
                cmd.Parameters.Add(new SqlParameter("@2rdClass", SqlDbType.Int)).Value = secTickets;
                cmd.Parameters.Add(new SqlParameter("@1rdClass", SqlDbType.Int)).Value = fTickets;
                cmd.Parameters.Add(new SqlParameter("@source", SqlDbType.VarChar)).Value = source;
                cmd.Parameters.Add(new SqlParameter("@destination", SqlDbType.VarChar)).Value = destination;
                cmd.Parameters.Add(new SqlParameter("@isactive", SqlDbType.Int)).Value = 1;
                cmd.Parameters.Add(new SqlParameter("@Total_Berth", SqlDbType.Int)).Value = Total_Berth;
                cmd.Parameters.Add(new SqlParameter("@available_Berth", SqlDbType.Int)).Value = Avaliable_Berth;

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Train Details are Inserted Successfully!");
                }
                else
                {
                    Console.WriteLine("Train Details are Not Inserted ");
                }
            }
            catch (Exception addTrain)
            {
                Console.WriteLine($"Error : {addTrain.Message}");
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Adisplay();
        }
        public void ModifyTrains()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("Enter The Trian Number :");
                int pnrNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The Source :");
                string source = Console.ReadLine();

                Console.WriteLine("Enter The Destination :");
                string destination = Console.ReadLine();

                cmd = new SqlCommand("sp_ModifyTrains", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@trainNumber", SqlDbType.Int)).Value = pnrNumber;
                cmd.Parameters.Add(new SqlParameter("@source", SqlDbType.VarChar)).Value = source;
                cmd.Parameters.Add(new SqlParameter("@destination", SqlDbType.VarChar)).Value = destination;
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Updated Train Details Successfully!");
                }
                else
                {
                    Console.WriteLine("Train Details are Not Updated ");
                }
            }
            catch (Exception updateTrain)
            {
                Console.WriteLine($"Error : {updateTrain.Message}");
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Adisplay();
        }
        public void DeleteTrains()
        {
            try
            {
                con = getConnection();

                Console.WriteLine("Enter The Train Number for Details : ");
                int dTrain = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("sp_DeleteTrains", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@trainNumber", SqlDbType.Int)).Value = dTrain;

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Deleted Train Successfully!");
                }
                else
                {
                    Console.WriteLine("Train Details are Not Deleted ");
                }
            }
            catch (Exception deleteTrain)
            {
                Console.WriteLine($"Error : {deleteTrain.Message}");
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Adisplay();
        }
    }
}

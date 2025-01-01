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
    public class UserTrain : IUser
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
        public void BookTickets()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("===========Booking Ticket===========");
                Console.WriteLine("Enter The Source : ");
                String source = Console.ReadLine();
                Console.WriteLine("Enter The Destination : ");
                string destination = Console.ReadLine();

                cmd = new SqlCommand("sp_Show", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@destination", destination);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine();
                    Console.WriteLine($" Train no : {dr[0]} | T_name : {dr[1]} | Firstclass : {dr[5]} | Second_class : {dr[4]} | Third Class : {dr[3]} | Sleeper_class : {dr[2]} | Avaliable_Berth : {dr[7]}");
                    Console.WriteLine();
                }
                dr.Close();

                Console.WriteLine("Enter Train Number :");
                int tNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select The Classes : SLEEPER || THIRDCLASS || SECONDCLASS || FIRSTCLASS");
                string classes = Console.ReadLine();
                Console.WriteLine("Enter Number Of Tickets : ");
                int tickets = Convert.ToInt32(Console.ReadLine());

                int temp = tickets;

                Console.WriteLine("Passenger Details : ");
                for (int i = 1; i <= tickets; i++)
                {
                    Console.WriteLine("Enter " + i + " Passenger Details : ");
                    Console.WriteLine("Enter Your Name : ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Your Gender : ");

                    string gender = Console.ReadLine();

                    Console.WriteLine("Enter Your Age : ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    cmd = new SqlCommand("sp_ticketbooking", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@train_No", SqlDbType.Int)).Value = tNum;
                    cmd.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar)).Value = name;
                    cmd.Parameters.Add(new SqlParameter("@p_age", SqlDbType.Int)).Value = age;
                    cmd.Parameters.Add(new SqlParameter("@gender", SqlDbType.VarChar)).Value = gender;
                    cmd.Parameters.Add(new SqlParameter("@class", SqlDbType.VarChar)).Value = classes;
                    cmd.Parameters.Add(new SqlParameter("@source", SqlDbType.VarChar)).Value = source;
                    cmd.Parameters.Add(new SqlParameter("@destination", SqlDbType.VarChar)).Value = destination;
                    cmd.Parameters.Add(new SqlParameter("@seats", SqlDbType.Int)).Value = 1;
                    cmd.Parameters.Add(new SqlParameter("@status", SqlDbType.VarChar)).Value = "Booked";

                    SqlParameter print_status = new SqlParameter("@display", SqlDbType.VarChar, 20);
                    print_status.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(print_status);
                    cmd.ExecuteNonQuery();
                    string bookingStatus = Convert.ToString(print_status.Value);
                    if (bookingStatus != "Booked")
                    {
                        temp = 0;
                        Console.WriteLine($"Booking Status : {bookingStatus} ");
                        Console.WriteLine("==============================================================================");
                    }
                }
                if (temp == tickets)
                {
                    Console.WriteLine("Booking Successful....");
                    Console.WriteLine("==============================================================================");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter valid input");
            }
            catch (Exception book)
            {
                Console.WriteLine($"Error :{book.Message}");
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Udisplay();
        }

        public void CancelTickets()
        {
            try
            {

                con = getConnection();

                Console.Write("Enter your PNR number : ");
                int pnr_no = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("sp_Cancelticket", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pnr_no", pnr_no);
                cmd.ExecuteNonQuery();

            }
            catch (Exception cancel)
            {
                Console.WriteLine($"cancel status : {cancel.Message}");
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Udisplay();
        }

        public void ShowAllTrains()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Source : ");
                String source = Console.ReadLine();
                Console.WriteLine("Enter The Destination : ");
                string destination = Console.ReadLine();

                cmd = new SqlCommand("sp_Show", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@source", SqlDbType.VarChar)).Value = source;
                cmd.Parameters.Add(new SqlParameter("@destination", SqlDbType.VarChar)).Value = destination;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("====================Train Details====================");
                    Console.WriteLine("Train_Number : " + dr[0] + " Train_Name : " + dr[1] + " Avaliable_Berth : " + dr[7] + " source : " + source + " Destination : " + destination);
                }
            }
            catch (Exception ticket)
            {
                Console.WriteLine(ticket.Message);
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Udisplay();
        }
        public void User_Booking()
        {
            try
            {
                con = getConnection();

                Console.WriteLine();

                Console.Write("Enter PNR No : ");
                int pnr = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("sp_showTicket", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pnr_no", pnr);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine();
                    Console.WriteLine($"Train no : {dr[4]} | PNR No : {dr[0]} | Name : {dr[1]} | Age : {dr[2]} | Gender : {dr[3]} | Class : {dr[7]} | status : {dr[8]} | Source : {dr[5]} | Destination : {dr[6]}");
                }
            }
            catch (Exception ticket)
            {
                Console.WriteLine(ticket.Message);
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("==============================================================================");
            Display.Udisplay();
        }

    }
}

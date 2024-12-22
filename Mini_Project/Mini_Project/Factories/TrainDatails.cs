using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.AbstractFactory;

namespace Mini_Project.Factories
{
    public static class TrainDatails
    {
        public static ITrainDetails GetDetails(string type)
        {
            if (type.Equals("Admin"))
            {
                return new AdminFactory();
            }
            else if (type.Equals("User"))
            {
                return new UserFactory();
            }
            else
            {
                throw new ArgumentException("Please Enter Either User Or Admin...");
            }
        }
    }
}

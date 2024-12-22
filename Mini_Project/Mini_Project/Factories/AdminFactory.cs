using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.ConcreateProducts;
using Mini_Project.AbstractFactory;

namespace Mini_Project.Factories
{
    class AdminFactory : ITrainDetails
    {
        public IAdmin CreateAdmin()
        {
            return new AdminTrain();
        }
        public IUser CreateUser()
        {
            throw new NotImplementedException();
        }
    }
}

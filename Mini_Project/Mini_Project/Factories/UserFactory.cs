using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.AbstractFactory;
using Mini_Project.ConcreateProducts;

namespace Mini_Project.Factories
{
    class UserFactory : ITrainDetails
    {
        public IUser CreateUser()
        {
            return new UserTrain();
        }
        public IAdmin CreateAdmin()
        {
            throw new NotImplementedException();
        }
    }
}

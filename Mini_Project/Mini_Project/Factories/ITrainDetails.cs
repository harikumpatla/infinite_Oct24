using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Project.AbstractFactory;

namespace Mini_Project.Factories
{
    public interface ITrainDetails
    {
        IUser CreateUser();
        IAdmin CreateAdmin();
    }
}

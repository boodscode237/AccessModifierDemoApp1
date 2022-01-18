using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SavePerson();
            Console.ReadLine();
        }
    }

    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecuredconnectionInfos()
        {
            GetConnectionString();
        }
    }
    public class CEO : Manager
    {
        public void getConnectonInfo()
        {
            DataAccess data = new DataAccess();         
            //formerLastName = "test";
        }
    }
}

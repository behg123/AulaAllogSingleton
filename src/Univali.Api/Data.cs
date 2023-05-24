using Univali.Api.Controllers;
using Unvali.Api.Entities;

namespace Univali.Api
{
    //Classes sem parametro
    public class Data
    {
        public List<Customer> Customers {get; set;}
        private static Data instance = new Data();

        public  CustomersController data = new CustomersController();

        private Data()
        {
            Customers = new List<Customer>();
            

        }

        public static Data instanceAcess(){
            if(instance == null)
            {
                instance = new Data();
            } 
            return instance;
        }
        

    }


}
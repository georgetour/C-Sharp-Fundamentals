using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals
{
   
        //An enum is a set of name.value pairs(contants) Instead of declaring multiple constants declare an enum
        //It's declared in high level in namespace since it's new type

        //if you want to create an application for different shipping methods for a company
        //You could
        //const int regularAirMail = 1;
        //const int registerAirMail = 2;
        //const int Express= 3;

        public enum ShippingMethod
        {
            regularAirMail =  1,
            registerAirMail = 2,
            Express = 3

        }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPAClient.Models
{
    public class AppState
    {
        public int AppLoading { get; set; }
        public AppState()
        {
            AppLoading = 0;
        }        
    }
}

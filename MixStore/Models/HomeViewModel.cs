using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixStore.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}

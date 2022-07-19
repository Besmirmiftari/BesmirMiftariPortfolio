using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BesmirMiftariPortfolio.Models {
    public class User {

      
        public string Name { get; set; }
        public string Message { get; set; }

        public User(string name, string message) {
            Name = name;
            Message = message;
        }
    }
}

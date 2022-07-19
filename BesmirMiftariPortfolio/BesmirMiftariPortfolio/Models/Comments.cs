using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BesmirMiftariPortfolio.Models {
    public static class Comments {


        public static List<User> AllComments = new List<User>();

        public static void defaultcomments() {

            AllComments.Add(new User("User1", "Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            AllComments.Add(new User("User2", "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s."));
            AllComments.Add(new User("User3", "When an unknown printer took a galley of type and scrambled it to make a type specimen book."));

            

        }

    }
}

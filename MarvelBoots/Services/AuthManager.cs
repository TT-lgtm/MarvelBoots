using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvelBoots.AppModels;

namespace MarvelBoots.Services
{
    class AuthManager
    {
        /// <summary>
        /// STUD
        /// Аутентификация.
        /// </summary>

        public static void Login(string username)
        {
            User user = Program.context.User
                .Where(u => u.Username == username)
                .First();

            UserSession.User = user;
        }


    }

}

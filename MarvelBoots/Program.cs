using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelBoots.AppForms;
using MarvelBoots.AppModels;

namespace MarvelBoots
{
    internal static class Program
    {
        public static ContextDb context = new ContextDb();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Ошибка соединения с базой данных",
                    "Ошибка соединения с базой данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}

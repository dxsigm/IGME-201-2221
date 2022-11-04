using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleLib;

namespace EditPerson
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // always call these 2 commands first for Windows Forms Applications
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Person student = new Student();
            PersonEditForm editForm = new PersonEditForm(student, null);
            
            Application.Run(editForm);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//classlibrary project conatins classes and enums.....etc
//class library project you can access with .dll File into another project,
//class library project doesnot contain main method.
namespace RepositoryLayer
{
    //accessmodifier class classname
    public class Class1         //public means you can access public any where in the project application.
    {
        //classmembers(whatever you written inside the class is called classmembers).
        //classmembers=variables+Methods.
        //=========Varaibles creation syntax================
        //Syntax:accessmodifier datatype varibalename=value;
        public string a = "hai";
        private string b = "hai1";
        protected string c = "hai2";
        internal string d = "hai3";
        /*MethodsCreation syntax
         ============================
              accessmodifier qualifier methodreturntype methodname()
               {
                return "yourdata"
               }
         */
        public void display()
        {
            Console.WriteLine("I am public method");
        }
        private void display1()
        {
            Console.WriteLine("I am private method");
        }
        protected void display2()
        {
            Console.WriteLine("I am protected method");
        }
        internal void display3()
        {
            Console.WriteLine("I am internal method");
        }
    }
}

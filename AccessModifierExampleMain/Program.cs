using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;//to add any project to another project use like(using yourpojectname);
namespace AccessModifierExampleMain
{
    internal class Program
    {
        static void Main(string[] args)
        { //scope starts here

            //To access outside non static classmembers we need to create a object
            Class1 obj = new Class1();
            Console.WriteLine(obj.public_a);
            //outside project only public variables or public methods we can access
            //(Remaining accessmodifiers like  private,protected,internal..we cannot access beacuse permission issue or access issue)
            //public variables and method we can access any anywhere in the current project classes or outside project classes.
            obj.Public_display();

            sample obj1 = new sample();
            Console.WriteLine(obj1.public_a2);//public variable we can access outside class and within current project and outside project also access.
            Console.WriteLine(obj1.internal_a4);//internal also we can access outside class and within the current prject only
            obj1.publicDisplayData();
            obj1.internalDisplayData();
            //==========Trying to access private accessmodier related classe outise assembly or outside project==//

            //==========Trying to access internal accessmodier related classe outise assembly or outside project==//
            // sipdashboard obj4 = new sipdashboard();
            //error:sipdashboard is inaccessible due to it's protectio level
            Console.ReadKey();
        }//scope ends here
    }
}

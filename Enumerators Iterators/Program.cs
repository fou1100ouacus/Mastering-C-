using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators_Iterators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id=1,Name="AYA", salary=937,Department="Engineer"};
            Employee e2 = new Employee { Id = 1, Name = "AYA", salary = 937, Department = "Engineer" };
            Employee e3 = e1; // e3 refer to reference of e1  then there has same reference
            /////// --------------- before using Operator overloading -------------------------
            Console.WriteLine(e1==e2);// false    compare refrence except string ==> compare content 
            Console.WriteLine(e1==e3);// True
            string s1 = "aya";
            string s2 = "aya";
            Console.WriteLine(s1==s2);// true 

            Console.WriteLine(e1.Equals(e2));//before override Equals, get ==> false because as default compare references 
            Console.WriteLine(e1.Equals(e2)); // true
            /////// --------------- After using Operator overloading -------------------------
            Console.WriteLine(e1==e2);// using  operator overloading 
            Console.WriteLine(e1==e3);// using  operator overloading 
///////////////////////////////////////////////////////////////////////////////////////////////////////////
///



        }
       
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal salary { get; set; }
            public string Department { get; set; }
            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is Employee))
                {
                    return false;
                }
                var emp = (Employee)obj;
                return (
                      this.Id == emp.Id &&
                      this.Name == emp.Name &&
                      this.Department == emp.Department &&
                      this.salary == emp.salary
                      ) ;
           // return base.Equals(obj);
        }
        
            public static bool operator ==(Employee lhs,Employee rhs  ) =>lhs.Equals(rhs);
            public static bool operator !=(Employee lhs, Employee rhs) => !lhs.Equals(rhs);

            public override int GetHashCode()
            {


                int hash = 13;// reduce the probability that 2 objects take the same content
                hash= hash*7+Id.GetHashCode();
                hash= hash*7+Name.GetHashCode();
                hash=hash*7+Department.GetHashCode();
                hash=hash*7+salary.GetHashCode();
                return hash;
            }

        }
    }
}

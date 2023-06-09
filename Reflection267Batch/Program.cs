﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection267Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....REFLECTION....");
            Console.WriteLine("Choose the Below Options");
            Console.WriteLine("\n1:finding nearest number" +
                "\n2:FetchingClass,Methods using Reflection" +
                "\n3:Creating Empty Object Using Reflection" +
                "\n4:Creating Parametrized Object Using Reflection" +
                "\n5:Invoke the method using Reflection \n22:Default");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    int n = 17;
                    int closest = Reflection.GetClosestEvenNumber(n);
                    Console.WriteLine($"The closest number to {n} with all even digits is {closest}");

                    int m = -33;
                    int closestM = Reflection.GetClosestEvenNumber(m);
                    Console.WriteLine($"The closest number to {m} with all even digits is {closestM}");
                    break;
                case 2:
                    Type type = typeof(Reflection);
                    MemberInfo[] members = type.GetMembers();
                    foreach (MemberInfo member in members)
                    {
                        Console.WriteLine(member.Name);
                    }
                    break;
                case 3:
                    {
                        Type type1 = typeof(Reflection);
                        object obj = Activator.CreateInstance(type1);
                        Console.WriteLine(obj.GetType().Name);
                    }
                    break;
                case 4:
                    Type type2 = typeof(Reflection);
                    ConstructorInfo constructor = type2.GetConstructor(new Type[] { typeof(string) });
                    object obj2 = constructor.Invoke(new object[] { "Raji" });
                    Console.WriteLine(obj2.GetType().Name); 
                    break;
                case 5:
                    Type type3 = typeof(Reflection);
                    MethodInfo method = type3.GetMethod("GetClosestEvenNumber");
                    object[] parameters = new object[] { 23 };
                    int result = (int)method.Invoke(null, parameters);
                    Console.WriteLine("Result: " + result);
                    break;
            }
            Console.ReadLine(); 
        }
    }
}

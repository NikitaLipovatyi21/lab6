using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_4_oop
{
 

    public static class MyClass
    {
        private static Dictionary<Type, Type> registeredTypes = new Dictionary<System.Type, System.Type>();

        static MyClass()
        {
            registeredTypes.Add(typeof(int), typeof(GenericInt));
            registeredTypes.Add(typeof(string), typeof(GenericString));
        }

        public static IFactory<T> FactoryMethod<T>()
        {
            var type = typeof(T);
            if (registeredTypes.ContainsKey(type) == false) throw new NotSupportedException();

            var typeToCreate = registeredTypes[type];
            return Activator.CreateInstance(typeToCreate, true) as IFactory<T>;
        }

    }

   

    public class GenericInt : IFactory<int>
    {
        public int Id { get; set; }

        public void ProcessEntity(int id)
        {
            Console.WriteLine(id);
        }
    }

    public class GenericString : IFactory<string>
    {
        public string Id { get; set; }

        public void ProcessEntity(string id)
        {
            Console.WriteLine(id);
        }
    }
}




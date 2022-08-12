using System;

namespace testVersion
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class History : Attribute
    {
        private string programmer;
        private double version;
        private string changes;

        //생성자
        public History(string programmer, double version, string changes)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }

        public double GetVersion()
        {
            return version;
        }

        public string Getchanges()
        {
            return changes;
        }
    }

    [History("Sean", 0.1, "2017-11-01 Created stub")]
    [History("Bob", 0.2, "2020-12-03 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);

            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history");

            foreach (Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                {
                    Console.WriteLine($"Ver : {h.GetVersion()}, Programmer : {h.GetProgrammer()} , Changes : {h.Getchanges()}");
                }
            }
        }
    }
}
using System;

namespace JsonConfiguration
{
    public class Client : IClient
    {
        private readonly AppSettings _app;

        public Client(AppSettings app)
        {
            _app = app;
        }

        public void WriteSettings()
        {
            Console.WriteLine($"Field1 has the following value: {_app.Field1}");

            Console.WriteLine($"Field2 has the following value: {_app.Child.Field2}");

            Console.WriteLine($"Field3 has the following value: {_app.Child.Field3}");
        }
    }
}
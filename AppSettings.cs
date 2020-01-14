namespace JsonConfiguration
{
    public class AppSettings
    {
        public string Field1 { get; set; }
        public Child Child { get; set; }
    }

    public class Child
    {
        public string Field2 { get; set; }
        public int Field3 { get; set; }
    }
}
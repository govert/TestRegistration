using ExcelDna.Integration;

namespace TestRegistration
{
    public static class Functions
    {
        [ExcelFunction]
        public static object SayHello() => "Hello from TestRegistration";
    }
}

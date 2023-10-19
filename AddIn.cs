using ExcelDna.Integration;
using ExcelDna.Registration;

namespace TestRegistration
{
    public class AddIn : IExcelAddIn
    {
        public void AutoOpen()
        {
            ExcelRegistration.GetExcelFunctions().RegisterFunctions();
        }

        public void AutoClose()
        {
        }
    }
}

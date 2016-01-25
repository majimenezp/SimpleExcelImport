using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using SimpleExcelImport;
using System.Collections.Generic;
using System.Reflection;
namespace UnitTests
{
    [TestClass]
    public class ReadTest
    {
        [TestMethod]
        public void ReadFile()
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var data=File.ReadAllBytes(Path.Combine(path,"productos.xls"));
            ImportFromExcel import = new ImportFromExcel();
            import.LoadXls(data);
            List<Producto> output=import.ExcelToList<Producto>(0,1);
            Assert.IsTrue(output.Count == 19);

        }
        [TestMethod]
        public void ReadFileXlsx()
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var data = File.ReadAllBytes(Path.Combine(path, "testXlsx.xlsx"));
            ImportFromExcel import = new ImportFromExcel();
            import.LoadXlsx(data);
            List<Producto> output = import.ExcelToList<Producto>(0, 1);
            Assert.IsTrue(output.Count == 18);

        }
    }
}

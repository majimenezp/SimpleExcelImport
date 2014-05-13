using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleExcelImport;
namespace UnitTests
{
    public class Producto
    {
        [ExcelImport("Codigo",order=1)]
        public string Codigo { get; set; }

        [ExcelImport("Descripcion", order = 2)]
        public string Descripcion { get; set; }

        [ExcelImport("Seccion", order = 3)]
        public string Seccion { get; set; }

        [ExcelImport("Categoria", order = 4)]
        public string Categoria { get; set; }

        [ExcelImport("IsLAN", order = 5)]
        public string IsLAN { get; set; }

        [ExcelImport("UMPri", order = 6)]
        public string UMPri { get; set; }

        [ExcelImport("UMSec", order = 7)]
        public string UMSec { get; set; }

        [ExcelImport("UMRec", order = 8)]
        public string UMRec { get; set; }

        [ExcelImport("FactorSec", order = 9)]
        public string FactorSec { get; set; }

        [ExcelImport("FactorRec", order = 10)]
        public string FactorRec { get; set; }
        
        [ExcelImport("ClaseContable", order = 11)]
        public string ClaseContable { get; set; }

        public Producto()
        {

        }
    }
}

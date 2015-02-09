SimpleExcelImport
=================

You want to import an simple excel file, load some data in your object in order to insert in the database using you favorite ORM.

But it's a problem, you need to write that all the logic in order to read your data from the excel, but here comes SimpleExcelImport.

What do you need?
Install the nuget package using:

Install-Package SimpleExcelImport

Decorate your object with the SimpleExcelImport's attributes:

``` csharp
public class Product
    {
        [ExcelImport("Code",order=1)]
        public string Code { get; set; }

        [ExcelImport("Description", order = 2)]
        public string Description { get; set; }

        [ExcelImport("Section", order = 3)]
        public string Section { get; set; }

        [ExcelImport("Width", order = 4)]
        public int Width { get; set; }
        
        [ExcelImport("Height", order = 4)]
        public int Height { get; set; }
}
```

Read all bytes from your excel files and read it with SimpleExcelImport to a List of object, and that is all!!
``` csharp
  var data=File.ReadAllBytes(@"C:\products.xls"));
  ImportFromExcel import = new ImportFromExcel();
  import.LoadXls(data);
  //first parameter it's the sheet number in the excel workbook
  //second parameter it's the number of rows to skip at the start(we have an header in the file)
  List<Product> output=import.ExcelToList<Product>(0,1);
  ```
  
Do you need read a excel file in Open Xml format(Xlsx excel 2007), you only need to change the method to load the file:  
``` csharp
  var data=File.ReadAllBytes(@"C:\products.xlsx"));
  ImportFromExcel import = new ImportFromExcel();
  import.LoadXlsx(data);
  //first parameter it's the sheet number in the excel workbook
  //second parameter it's the number of rows to skip at the start(we have an header in the file)
  List<Product> output=import.ExcelToList<Product>(0,1);
 ``` 
 Also added method to load directly the file only with path(no need to load in memory the file in order to be read by the library).
 
 
 
 

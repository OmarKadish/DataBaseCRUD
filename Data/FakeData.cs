using System.Collections.Generic;
using DataBaseCRUD.Models;

namespace DataBaseCRUD.Data
{
    public class FakeData
    {
        public List<Employee> Employees = new List<Employee> 

        { 
            new Employee {Id = 1531, Name = "Ahmet", SureName = "Çokçalışır", Address="Toki", Photo = "ahmet.jpg"}, 

            new Employee {Id = 1532, Name = "Mehmet", SureName = "Hiçdurmaz", Address="Toki", Photo = "mehmet.jpg"}, 

            new Employee {Id = 1533, Name = "Hasan", SureName = "Yorulmaz", Address="Toki", Photo = "hasan.jpg"}, 

            new Employee {Id = 1534, Name = "Hüseyin", SureName = "Kulakasmaz", Address="Toki", Photo = "huseyin.jpg"}, 

            new Employee {Id = 1535, Name = "Ayşe", SureName = "İşyapar", Address="Toki", Photo = "ayse.jpg"}, 

            new Employee {Id = 1536, Name = "Fatma", SureName = "Durdurakbilmez", Address="Toki", Photo = "fatma.jpg"}, 

            new Employee {Id = 1537, Name = "Hatice", SureName = "İşbilir", Address="Toki", Photo = "hatice.jpg"}, 

            new Employee {Id = 1538, Name = "Zeynep", SureName = "Hepçalışır", Address="Toki", Photo = "zeynep.jpg"}, 

        }; 
    }
}
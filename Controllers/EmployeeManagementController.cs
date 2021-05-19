using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseCRUD.Models;
using DataBaseCRUD.Data;

namespace DataBaseCRUD.Controllers
{
    public class EmployeeManagementController : Controller
    {
        private readonly AppDbContext _context;
        //private readonly FakeData _context;

        //Dependency Injection. Bağımlı Enjeksiyon
        public EmployeeManagementController(AppDbContext context) //Constructure
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Employees);
        }

        //method-----> Action To Open The View.
        public IActionResult Create()
        {
            return View();//form ----->>>>>>>model binding>>>>>>>>----------> Personel
            // will get the object from the form in our view 
            //and pass it to the other create function to be saved in the database.
        }
        [HttpPost] // Post\Save Action To Save The Writen Informations in The View To The DB.
        public IActionResult Create(Employee employee)
        {
             //this function will save the passed object from the previous function into the database. 
            _context.Employees.Add(employee);
            return RedirectToAction("Index");
        }

        //method-----> Action For Showing Details.
        public IActionResult Details(int id)
        {
            var employee = _context.Employees.Where(x => x.Id == id).SingleOrDefault();
            return View(employee);
        }
        // Action For Deleting an Employee By His Id.
        public IActionResult Delete(int id)
        {
            //We have to add some conformation to this action.
            var employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            //var employee1 = _context.Employees;
            _context.Employees.Remove(employee);
            return RedirectToAction("Index");
        }

        //method-----> Action
        public IActionResult Edit(int id)
        {
            // id(int) ------- LINQ   -------> Employee(reference)
            var employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            return View(employee); // form <----model binding----- Employee
        }

        //method-----> Post\Save Action
        [HttpPost]
        public async Task<IActionResult> Edit(Employee _selectedEmployee)
        {
            var _toupdateEmployee = _context.Employees.Where(x => x.Id == _selectedEmployee.Id).SingleOrDefault();
            await TryUpdateModelAsync(_toupdateEmployee);
            //_context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
namespace DataBaseCRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string Address { get; set; }
        private string _fullName;
        public string FullName
        {
            get { return Name+" "+SureName; }
            set { _fullName = value; }
        }
        public string Photo { get; set; }

    }
}
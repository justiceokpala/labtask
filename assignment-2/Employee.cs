namespace EmployeeTest {
    public class Employee{
         public  string name;

         public string lastname;

        public decimal monthlysalary;
         public string Name
        {
            get
            { 
                return name;     
            }
            set 
            {
                name = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
            
             lastname = value;
                
               
            }
        }

        public decimal Monthlysalary
        {
            get
            {
                return monthlysalary;
            }
            set
            {
            
             if(value < 0.0M)
                {
                 monthlysalary = 0;
                } else {
                    monthlysalary = value;
                }
                
               
            }
        }

           public Employee(string name, string lastname, decimal monthlysalary)
        { 
           Name = name;
           Lastname = lastname;
           Monthlysalary = monthlysalary;
        }
    }
}













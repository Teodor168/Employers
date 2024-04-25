namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employe> employes = new List<Employe>();
            for (int i = 0; i < n; i++)
            {
                Employe employer = new Employe();
                employer.Name = Console.ReadLine();
                employer.Salary = double.Parse(Console.ReadLine());
                employer.Occupation = Console.ReadLine();
                employer.Department = Console.ReadLine();
                employes.Add(employer);
            }

            for (int i = 0; i < employes.Count - 1; i++)
            {
                for (int j = 0; j < employes.Count - i - 1; j++)
                {
                    int compare = employes[j].Department.CompareTo(employes[j + 1].Department);
                    if (compare > 0)
                    {
                        string tempVar = employes[j].Department;
                        employes[j].Department = employes[j + 1].Department;
                        employes[j + 1].Department = tempVar; 
                    }
                }
            }

            //double HighestAverage = 0;
            //int sameDepartmentBr = 0;
            //double CurrentHighestAverage = 0;
            //int index = 0;
            //List<Emplyee> RichestDepartment = new List<Emplyee>();
            //for (int j = 0; j < employees.Count - 1; j++)
            //{
            //    int cmpVal = employees[j].Department.CompareTo(employees[j + 1].Department);
            //    if (cmpVal == 0)
            //    {
            //        HighestAverage += employees[j].Salary;
            //        sameDepartmentBr++;
            //        RichestDepartment.Add(employees[j]);
            //    }
            //    else
            //    {
            //        HighestAverage /= sameDepartmentBr;
            //        if (CurrentHighestAverage < HighestAverage)
            //        {
            //            index = j;
            //            CurrentHighestAverage = HighestAverage;

            //        }
            //        else
            //        {
            //            RichestDepartment.Clear();
            //        }
            //    }
            //}

            string currentDepartment = null;

            foreach (var employee in employes)
            {
                if (employee.Department != currentDepartment)
                {
                    Console.WriteLine($"\nDepartment: {employee.Department}");
                    currentDepartment = employee.Department;
                }
                employee.Print();

            }
        }
    }
}
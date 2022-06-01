using System;

namespace HomeTask50_sub9
{
   public class Employees
    {
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Age { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }

        public Employees(string _fullname,string _position, string _office, string _age, string _startDate, string _salary)
        {
            this.Fullname = _fullname;
            this.Position = _position;
            this.Office = _office;
            this.Age = Int32.Parse(_age);
            this.StartDate = _startDate;
            this.Salary = this.SalaryToInt(_salary);

        }
        public Employees()
        {

        }

        public dynamic this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        {
                            this.Fullname = value;
                            break;
                        }
                    case 1:
                        {
                            this.Position = value;
                            break;
                        }
                    case 2:
                        {
                            this.Office = value;
                            break;
                        }
                    case 3:
                        {
                            this.Age = Int32.Parse(value);
                            break;
                        }
                    case 4:
                        {
                            this.StartDate = value;
                            break;
                        }
                    case 5:
                        {
                            this.Salary = this.SalaryToInt(value);
                            break;
                        }
                    default: throw new ArgumentOutOfRangeException("Invalid Index");
                }
            }
        }
        
        public int SalaryToInt(string wage)
        {
            char[] charsToTrim = { '$', ',', '/','y' };
            wage = wage.Trim(charsToTrim);
            wage = wage.Replace(",","");
            return Int32.Parse(wage);
        }      
    }
}

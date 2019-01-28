using System;

namespace StudentInfo1
{
    class StudentInfo
    {
        public StudentInfo(int id, string name, int maths, int science)
        {
            this.Id = id;
            this.Name = name;
            this.Mark1 = maths;
            this.Mark2 = science;
            this.Total = maths + science;
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value.Equals(""))
                {
                    throw new Exception("Ivalid Name");
                }
                else
                {
                    _Name = value;
                }
            }
        }

        public int Id { get; set; }

        private int _Mark1;
        public int Mark1
        {
            get { return _Mark1; }
            set
            {
                if (value <= 50 && value >= 0)
                {
                    _Mark1 = value;
                }
                else
                {
                    throw new InvalidMarksException("Enter the Invalid Mark ! (0=>marks<=50)");
                }
            }
        }

        private int _Mark2;
        public int Mark2
        {
            get { return _Mark2; }
            set
            {
                if (value <= 50 && value >= 0)
                {
                    _Mark2 = value;
                }
                else
                {
                    throw new InvalidMarksException("Enter the Invalid Mark ! (0=>marks<=50)");
                }
            }
        }

        public int _Total;
        public int Total
        {
            get { return _Total; }
            set
            {
                if (value > 95)
                {
                    this.Grade = 'A';
                }
                else if (value <= 95 && value >= 85)
                {
                    this.Grade = 'B';
                }
                else
                {
                    this.Grade = 'C';
                }
                _Total = value;
            }
        }

        public char Grade { get; set; }
    }
}

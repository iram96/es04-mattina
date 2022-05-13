namespace MyApp
{
    public class Student
    {
        //Proprietà (privata)
        private string _myPropertyInternalMatricolaStudente;

        public string MyPropertyPublicMatricolaStudente
        {
            get
            {
                return _myPropertyInternalMatricolaStudente.Substring(5);
            }

            set
            {
                if (Age < 20)
                    _myPropertyInternalMatricolaStudente = "00021" + this.StudentName.Substring(0, 5) + value;
                // value è l'argomento della set
                else
                    _myPropertyInternalMatricolaStudente = "00022" + this.StudentName.Substring(0, 5) + value;
            }
        }


        //Esempi di Auto-implemented Property
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }


    class EsempioUsoClassStudent
    {
        public void EsempioUsoClassStudent_Main()
        {
            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "Mariano",
                Age = 20,
                Address = "New York",
                MyPropertyPublicMatricolaStudente = "200"
            };

            int iStudentID = std.StudentID;
            string sAppo = std.MyPropertyPublicMatricolaStudente;

            Console.WriteLine("ciao");
        }
    }
}


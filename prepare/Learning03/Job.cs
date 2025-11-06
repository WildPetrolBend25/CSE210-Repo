
public class Job
    {
        public string _companyTitle = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;

        public void Display()
        {
            //display the info function
            Console.WriteLine($"{_jobTitle} ({_companyTitle}) {_startYear}-{_endYear}");
        }
    }
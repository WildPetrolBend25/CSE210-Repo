using System;

class Doctor : Person
{
    //atributes
    private string _tools;

    //methods
    public Doctor(string tools, string firstname, string lastname, int age, int weight): base(firstname, lastname, age, weight)
    {
        _tools = tools;
    }

    public string DoctorInformation()
    {
        return $"Doctor: {base.GetPersonalInformation()} {_tools}";
    }

      public override string GetPersonalInformation()
    {
        return $"Doctor: {base.GetPersonalInformation()} {_tools}";
    }

    public override double GetSalary()
    {
        return 600000.02;
    }
}
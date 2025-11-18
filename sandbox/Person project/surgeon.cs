using System;

class Surgeon : Doctor
{
    //atributes
    private string _title = " ";

    //methods
    public Surgeon(string title, string tools, string firstname, string lastname, int age, int weight): base(tools, firstname, lastname, age, weight)
    {
        _title = title;
    }

    public string GetSurgeonInformation()
    {
        return $"Surgeon: {base.GetPersonalInformation()} {_title}";
    }
}
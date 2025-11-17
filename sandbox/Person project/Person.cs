
class Person
{
    //attributes
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    //constructor
    public Person(string firstname, string lastname, int age, int weight)
    {
        _firstName = firstname;
        _lastName = lastname;
        _age = age;
        _weight = weight;
    }

    //display perosnal info
    public string GetPersonalInformation()
    {
        string PerInfo = $"{_firstName}, {_lastName}, Age:{_age}, weight:{_weight}";
        return PerInfo;
    }

    

}
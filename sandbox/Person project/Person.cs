
class Person
{
    //attributes
    private string _firstName;
    private string _lastName;
    protected int _age;
    private int _weight;

    //constructor
    public Person(string firstname, string lastname, int age, int weight)
    {
        _firstName = firstname;
        _lastName = lastname;
        SetAge(age);
        _weight = weight;
    }

    //display perosnal info
    public string GetPersonalInformation()
    {
        string PerInfo = $"Person: {_firstName}, {_lastName}, Age:{_age}, weight:{_weight}";
        return PerInfo;
    }

    //checks for valid weights
    public void SetAge(int age)
    {
        if (age < 0 || age > 124)
        {
            Console.WriteLine("Invalid age");
            _age = 0;
        }
        else
        {
            _age = age;
        }
    }


    

}
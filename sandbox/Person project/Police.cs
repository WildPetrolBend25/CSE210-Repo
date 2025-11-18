class Police : Person
{
    //private attribute
    private string _weapons = " ";

    public Police(string weapons, string firstname, string lastname, int age, int weight): base(firstname, lastname, age, weight)
    {
        _weapons = weapons;

        //protected variabkles can be directly access by child classes, no longer have to use setter method
        _age = age;
    }

    //calls method in person class
    public string GetPoliceInformation()
    {
        //don't need base, but you can have base.getpersonalinformation
        return $"Policeman: {base.GetPersonalInformation()}, Weapons: {_weapons}";
    }
}

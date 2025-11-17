class Police : Person
{
    //private attribute
    private string _weapons = " ";

    public Police(string weapons, string firstname, string lastname, int age, int weight): base(firstname, lastname, age, weight)
    {
        _weapons = weapons;
    }

    //calls method in person class
    public string GetPoliceInformation()
    {
        return $"{base.GetPersonalInformation()}, Weapons: {_weapons}";
    }
}

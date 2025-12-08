using System;
class Menu
{
    // attributes
    List<string> _menuOptions = new List<string>()
    {
        "Option 1",
        "Option 2",
        "Option 3"
    };

    // constructors
    public Menu()
    {
        
    }
    // methods
    public List<string> GetMenu()
    {
        return _menuOptions;
    }
}
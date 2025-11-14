using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //private attributes
    private List<string> _ScriptureList = [];

    //ScriptureList Getter
    public List<string> GetScriptureList()
    {
        return _ScriptureList;
    }

    //Scripture Constrcuctor
    public Scripture(List<string> list)
    {
        _ScriptureList = list;
    }
    
    
}
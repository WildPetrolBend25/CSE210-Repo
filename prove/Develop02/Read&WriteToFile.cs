using System.IO;

class journalEntry
{
    public void writeToFile() //add the journalEntry parameter
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        } 
    }

    public string readFromFile()
    {
        string username = "Hello";
        return username;
    }
}
using System;
using System.Data.Common;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date = DateTime.Now.ToString("dd/mm/yyyy");
    public string getEntry();
    {
        string _userInput = Console.ReadLine();
        return _userInput;


    }
    public string entryPackager();
    {
        PromtGenerator promt = new PromtGenerator();
        _promt = promt.GetPromt();
        Console.WriteLine(_prompt);
        _entry = getEntry();

        _entry = "\n" + _date + "\n" + _promt + "\n" + _entry + "\n";
        return _entry:

    }



}

}
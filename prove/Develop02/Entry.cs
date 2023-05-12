using System;
using System.Collections.Generic;
using System.IO;
public class Entry // Entry class
{
    //Each property uses the get and set method pattern which allows 
    //reading and writing the value of the property from outside the class
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public string AdditionalInfo { get; set; } // New property, show creativity

    //Take the arguments and assing values
    public Entry(string prompt, string response, string additionalInfo)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
        AdditionalInfo = additionalInfo;
    }
    //Display  data
    public override string ToString()
    {
        return ($"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nAdditional Info: {AdditionalInfo}\n");
    }
}
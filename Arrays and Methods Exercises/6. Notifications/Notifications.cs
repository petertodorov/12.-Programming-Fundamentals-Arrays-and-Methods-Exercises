using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Notifications
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string result = "";
        string operation = "";
        string message = "";
        string toShow = "";
        for (int i = 0; i < n; i++)
        {
            result = Console.ReadLine();
            if (result=="success")
            {
                operation = Console.ReadLine();
                message = Console.ReadLine();
                toShow = ShowSuccess(operation, message);
                Console.WriteLine(toShow);
            }
            else if (result =="error")
            {
                operation = Console.ReadLine();
                int code= int.Parse(Console.ReadLine());
                toShow = ShowError(operation, code);
                Console.WriteLine(toShow);
            }
            else
            {
                continue;
            }
        }
    }

    private static string ShowError(string operation, int code)
    {
        string reason = "";
        if (code>0)
        {
            reason = "Invalid Client Data";
        }
        else
        {
            reason = "Internal System Failure";
        }
        string[] temp = new string[] { "Error: Failed to execute ", operation, ".", "\n", "==============================", "\n", "Error Code: ", Convert.ToString(code), ".", "\n","Reason: ", reason, "."};
        string result = string.Join("", temp);
        return result;
    }

    private static string ShowSuccess(string operation, string message)
    {
        string[] temp = new string[] {"Successfully executed ", operation, ".","\n", "==============================", "\n","Message: ", message, "." };
        string result = string.Join("", temp);
        return result;
    }
}

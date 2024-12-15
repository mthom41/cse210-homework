using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Password Manager!");
        PasswordManager _manager = new PasswordManager();
        _manager.SetSecret();
        string ans = "";
        while(ans != "quit" && ans != "q"){
            Console.WriteLine("Options:\n1. New Password\n2. List Passwords (hints only)");
            Console.WriteLine("3. Display Passwords (full)\n4. Display Specific Password\n5. Get a Hint \n6. Modify a password \n7. Change Master Secret\n8. Quit (or type quit)");
            ans = Console.ReadLine();
            Console.Clear();
            if(ans == "1"){
                _manager.AddPassword();
            }
            else if(ans == "2"){
                _manager.ListAll();
            }
            else if(ans == "3"){
                _manager.DisplayAll();
            }
            else if(ans == "4"){
                _manager.DisplaySpecific();
            }
            else if(ans == "5"){
                _manager.ListAll();
                Console.WriteLine("Which password would you like help for?");
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number) - 1;
                _manager.GetHelp(num);
            }
            else if(ans == "6"){
                _manager.ListAll();
                Console.WriteLine("Which password would you like to modify?");
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number) - 1;
                _manager.Modify(num);
            }
            else if(ans == "7"){
                _manager.SetSecret();
            }
            else if(ans == "8"){
                ans = "quit";
                continue;
            }
            else{
                continue;
            }
            Console.Clear();
        }
        Console.WriteLine("Goodbye!");
    }
}
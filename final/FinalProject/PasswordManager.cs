class PasswordManager{
    List<Password> _passwords = new List<Password>();
    StrengthChecker _checker = new StrengthChecker();
    private string _masterSecret;
    public void DisplayAll(){
        foreach(Password pwd in _passwords){
            // this should list all the descriptions, but not show if the secrets don't match
            Console.WriteLine(pwd.GetDescription());
            Console.WriteLine(pwd.Retrieve(_masterSecret));
        }
    }
    public void ListAll(){
        int i = 1;
        foreach(Password pwd in _passwords){
            Console.WriteLine($"{i} {pwd.GetDescription()}");
            i++;
        }
    }
    public void DisplaySpecific(){
        ListAll();
        Console.WriteLine("Which password would you like to retrieve?");
        string number = Console.ReadLine();
        int num = Convert.ToInt32(number) - 1;
        Console.WriteLine(_passwords[num].Retrieve(_masterSecret));
    }
    public void AddPassword(){
        Console.WriteLine("Which kind of password woul you like to create?");
        Console.WriteLine("1. Standard\n2. Weak\n3. Strong\n4. Super Strong\n5. PassPhrase");
        string ans = Console.ReadLine();
        Password _tempPass;
        if(ans == "1"){
            _tempPass = new StandardPassword();
        }
        else if(ans == "2"){
            _tempPass = new WeakPassword();
        }
        else if(ans == "3"){
            _tempPass = new StrongPassword();
        }
        else if(ans == "4"){
            _tempPass = new SuperStrongPassword();
        } 
        else if(ans == "5"){
            _tempPass = new PassPhrase();
        }
        else{
            Console.WriteLine("Unknown input, exiting...");
            return;
        }
        _tempPass.Create(_checker, _masterSecret);
        _passwords.Add(_tempPass);
    }
    public void Modify(int num){
        Password pass = _passwords[num];
        if(pass.GetSecret() == _masterSecret){
            pass.Create(_checker, _masterSecret);
        } 
        else{
            Console.WriteLine("Secrets do not match.");
        }
    }
    public void GetHelp(int num){
        Password pass = _passwords[num];
        Console.WriteLine(pass.GetDescription());
        Console.WriteLine($"Hint: {pass.GetHint()}");
    }
    public void SetSecret(){
        string ans;
        if(_masterSecret == null){
            Console.WriteLine("Create new master mecret: \n");
        }
        else{
            Console.WriteLine("Replace current master secret? (y/n)");
            ans = Console.ReadLine();
            if(ans != "y"){
                Console.WriteLine("Aborting master secret override...");
                return;
            }
            else{
                Console.WriteLine("Input new master secret: \n");
            }
        }
        ans = Console.ReadLine();
        _masterSecret = CreateMD5(ans);
        return;
    }
    // I found this md5 hashing method on stackoverflow. Learning how hashing works can be complicated.
    public static string CreateMD5(string input){
    using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
    {
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);
        return Convert.ToHexString(hashBytes);
    }
}
}
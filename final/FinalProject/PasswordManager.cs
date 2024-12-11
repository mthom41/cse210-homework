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
    public void Modify(Password pass){
        if(pass.GetSecret() == _masterSecret){
            pass.Create(_checker, _masterSecret);
        } 
        else{
            Console.WriteLine("Secrets do not match.");
        }
    }
    public void GetHelp(Password pass){
        Console.WriteLine(pass.GetDescription());
        Console.WriteLine(pass.GetHint());
    }
}
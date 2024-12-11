class PasswordManager{
    List<Password> _passwords = new List<Password>();
    private string _masterSecret;
    public void DisplayAll(){
        foreach(Password pwd in _passwords){
            // this should list all the descriptions, but not show if the secrets don't match
            Console.WriteLine(pwd.GetDescription());
            Console.WriteLine(pwd.Retrieve(_masterSecret));
        }
    }
    public void Modify(Password pass){
        // verify secrets then run pass.Create()
    }
    public void GetHelp(Password pass){
        Console.WriteLine(pass.GetDescription());
        Console.WriteLine(pass.GetHint());
    }
}
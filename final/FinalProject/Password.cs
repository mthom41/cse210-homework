class Password{
    protected string _secret;
    protected string _hint;
    protected string _password;
    protected int _minLength;
    protected int _minSpecialCharacters;
    protected int _minDigits;
    protected int _minCapitals;
    protected bool _isHashed;
    protected string _description;
    protected string _type;
    public Password(){
        _isHashed = false;
    }
    public virtual string Retrieve(string MasterSecret){
        if(MasterSecret == _secret){
            return _password;
        }
        else{
            return "Secrets do not match";
        }
    }
    public virtual void Create(StrengthChecker checker, string master_secret){
        _secret = master_secret;
        Console.WriteLine("What is this passsword for?");
        _description = Console.ReadLine();
        Console.WriteLine("What is a hint for this password?");
        _hint = Console.ReadLine();
        Console.WriteLine($"{_type} requirements: \n{_minLength} characters \n{_minCapitals} capital letters \n{_minDigits} digits \n{_minSpecialCharacters} special characters");
        Console.WriteLine("Please input your password: ");
        _password = Console.ReadLine();
        if(checker.Evaluate(this, master_secret)){
            Console.WriteLine("Password Created");
        }
        else{
            Console.WriteLine("Did not meet requirements. Password not created.");
            _password = "1"; // since this value is impossible to set via create(), we can check it to decide whether we add it to the list
        }
    }
    public string GetSecret(){
        return _secret;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetHint(){
        return _hint;
    }
    public List<int> GetRequirements(){
        return [_minLength, _minCapitals, _minDigits, _minSpecialCharacters];
    }
}
class Password{
    protected string _secret;
    protected string _password;
    protected bool _isEncrypted;
    protected int _minLength;
    protected int _minSpecialCharacters;
    protected int _minDigits;
    protected int _minCapitals;
    protected bool _isHashed;
    protected string _description;
    protected string _type;
    public Password(){
        _isHashed = false;
        _isEncrypted = false;
    }
    
    public virtual string Retrieve(string MasterSecret){
        if(MasterSecret == _secret){
            return _password;
        }
        else{
            return "Secrets do not match";
        }
    }
    public virtual void Create(StrengthChecker checker){
        checker.Evaluate(this);
    }
    public virtual void Load(){}
    public string GetSecret(){
        return _secret;
    }
    public string GetDescription(){
        return _description;
    }
}
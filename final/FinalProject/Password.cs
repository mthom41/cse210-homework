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
        checker.Evaluate(this, master_secret);
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
        /*int[] reqs =[0,0,0,0];
        reqs[0] = _minLength;
        reqs[1] = _minCapitals;
        reqs[2] = _minDigits;
        reqs[3] */
        return [_minLength, _minCapitals, _minDigits, _minSpecialCharacters];
    }
}
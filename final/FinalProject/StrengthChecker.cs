class StrengthChecker{
    private List<char> _specialCharacters = ['!','@','#','$','%','^','&','8','(',')','{','[',']','}','.','?'];
    public void Evaluate(string str){
        // see if the string matches criteria for the type, given an option menu. prints result
    }
    public void Evaluate(string str, string type){
        // see if the string matches criteria for the type. simply prints result
    }
    public bool Evaluate(Password pass, string master_secret){
        string password = pass.Retrieve(master_secret);
        List<int> reqs = pass.GetRequirements();
        //more code
        return true;
    }
}
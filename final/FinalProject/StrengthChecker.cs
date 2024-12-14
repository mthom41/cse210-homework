class StrengthChecker{
    public bool Evaluate(Password pass, string master_secret){
        string password = pass.Retrieve(master_secret);
        List<int> reqs = pass.GetRequirements();
        List<int> actual = [0,0,0,0];
        bool valid = true;
        foreach(char c in password){
            actual[0]++;
            if(Char.IsLower(c)){
                continue;
            }
            else if(Char.IsUpper(c)){
                actual[1]++;
            }
            else if(Char.IsNumber(c)){
                actual[2]++;
            }
            else{
                actual[3]++;
            }
        }
        for(int i=0; i<4; i++){
            if(reqs[i] == actual[i]){
                valid = true;
            }
            else{
                valid = false;
                break;
            }
        }
        return valid;
    }
}
class StandardPassword : Password{
    public StandardPassword() : base(){
        _minCapitals = 1;
        _minDigits = 1;
        _minLength = 8;
        _minSpecialCharacters = 1;
        _type = "Standard";
    }
}
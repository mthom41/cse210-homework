class StrongPassword : Password{
    public StrongPassword() : base(){
        _minCapitals = 3;
        _minDigits = 2;
        _minSpecialCharacters = 3;
        _minLength = 12;
        _type = "Strong";
    }
}
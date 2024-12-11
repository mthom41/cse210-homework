class WeakPassword : Password{
    public WeakPassword() : base(){
        _minCapitals = 1;
        _minDigits = 1;
        _minLength = 6;
        _minSpecialCharacters = 1;
        _type = "Weak";
    }
}
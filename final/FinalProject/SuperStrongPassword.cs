class SuperStrongPassword  : Password{
    public SuperStrongPassword() : base(){
        _minCapitals = 3;
        _minDigits = 3;
        _minLength = 14;
        _minSpecialCharacters = 3;
        _type = "SuperStrong";
    }
}
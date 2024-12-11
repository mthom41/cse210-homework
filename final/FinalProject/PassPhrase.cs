class PassPhrase : Password{
    public PassPhrase() : base(){
        _minCapitals = 1;
        _minDigits = 1;
        _minLength = 20;
        _minSpecialCharacters = 1;
        _type = "PassPhrase";
    }
}
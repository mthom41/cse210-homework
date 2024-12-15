This is a client-side password manager!
Because storing passwords in cleartext is an awful security practice, and cryptography is quite a beast, I have elected not to us files to save and load passwords in this implementation of the program.

To use the program, simply run it with dotnet. It should be fairly self explanatory as you read through the menus. If you want to keep your passwords secure, simply change mater secrets. Other users of the program will not be able to view any of your passwords unless they use your master secret (or if they decide to use a memory debug tool).
## Password Generator 
##### *by Gaudium*

------

>Console password generator written on C#

### Options

|    Name     | Short Name  | Argument type | Description                                                                                                     |
|:-----------:|:-----------:|:-------------:|-----------------------------------------------------------------------------------------------------------------|
|  --length   |     -L      |      int      | Sets password length (default: 16)                                                                              |                                                                   
|  --digits   |     -d      |      int      | Sets the exact number of digits (0 for random) (default: 0)                                                     |                                  
|  --letters  |     -l      |      int      | Sets the exact number of letters (both lowercase and uppercase if -u option is set) (0 for random) (default: 0) |
| --uppercase |     -u      |               | Uses uppercase letters                                                                                          |  
|  --special  |     -s      |               | Uses special symbols (@, #, $ etc.)                                                                             |  
|   --file    |     -f      |    string     | Sets path to write to the file                                                                                  |
|   --seed    |             |      int      | Sets seed (default: random)                                                                                     |
|   --debug   |             |               | Enable debug mode                                                                                               |
|   --help    |     -h      |               | Shows help message                                                                                              |


- *Options that have a short name and no arguments can be written as __-<opt1><opt2>...<optn>__ (Example: __-us__)*

- *All options are __optional__*

### Usage
``` sh
PassGen.exe 
>>> Your Password: m9q76j221t6j15o5

PassGen.exe -L 20 -us -d 7
>>> Your Password: l87k@1dm3DFq9s*4Me3J

PassGen.exe --digits 7 --letters 3 --seed 1024 
>>> Warning! Length will be 10 (7 + 3)
>>> Your Password: 2t5i83880b

PassGen.exe -d 5 --length 7 --letters 5
>>> Length must be equals or greater (Digits + Letters)!

PassGen.exe -L 100 -us -f NoSecretsHere.txt
>>> Your Password is written to NoSecretsHere.txt.
```
Similar to File and FileInfo
- We have static methods and instance methods

Directory.CreateDirectory
- Creates new directory

Directory.GetFiles
- Get file from a given directory
- Three overloads 
- First overload the path
- Second overload path and search pattern(example jpg extension)
- Third overload takes a parameter of this pattern which is an enumeration
- GetFiles returns an array string so we can ittirate with a foreach loop 

Directory.GetDirectories
- We get only directories of directory
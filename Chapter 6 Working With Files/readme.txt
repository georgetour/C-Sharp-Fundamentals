- System.Io.Namespace contains all classes for files

- File, FileInfo
* Provide methods for creating, copying, deleting,moving, abd opening files
** FileInfo: instance methods(the security checking happens only once when the FileInfo object is created)
** File: static methods(the OS check for security and if we have access for those files)

-- File, FileInfo Methods--
* Create()
* Copy()
* Delete
* Exists()
* GetAttributes()
* Move()
* ReadAllText()



- Directory, DirectoryInfo
** DirectoryInfo: instance methods(the security checking happens only once when the FileInfo object is created)
** Directory: static methods(the OS check for security and if we have access for those files)

-- Directory, DirectoryInfo Methods--
* CreateDirectory()
* Delete()
* Exists()
* GetCurrentDirectory()
* GetFiles()
* Move()
* GetLogicalDrives()



- Path(work with a string that contains a path or directory info)
* GetDirectoryName()
* GetFileName()
* GetExtension()
* GetTempPath()

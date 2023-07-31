#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintFileUtilsBPLibrary.h")]
public partial class UBlueprintFileUtilsBPLibrary : UBlueprintFunctionLibrary {
	///<summary>Finds all the files within the given directory, with optional file extension filter.</summary>
	public static bool FindFiles(string Directory,TArray<string> FoundFiles,string FileExtension/*=TEXT("")*/) { return default; }
	///<summary>Finds all the files and/or directories within the given directory and any sub-directories.  Files can be found with anoptional file extension filter.</summary>
	public static bool FindRecursive(string StartDirectory,TArray<string> FoundPaths,string Wildcard/*=TEXT("")*/,bool bFindFiles/*=true*/,bool bFindDirectories/*=false*/) { return default; }
	///<summary>Checks if a file exists</summary>
	public static bool FileExists(string Filename) { return default; }
	///<summary>Checks if a directory exists</summary>
	public static bool DirectoryExists(string Directory) { return default; }
	///<summary>Makes a new directory, and optionally sub-directories</summary>
	public static bool MakeDirectory(string Path,bool bCreateTree/*=false*/) { return default; }
	///<summary>Deletes a directory and all the files in it and optionally all sub-directories and files within it</summary>
	public static bool DeleteDirectory(string Directory,bool bMustExist/*=false*/,bool bDeleteRecursively/*=false*/) { return default; }
	///<summary>Deletes a file.</summary>
	public static bool DeleteFile(string Filename,bool bMustExist/*=false*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	///<summary>Copies a file.</summary>
	public static bool CopyFile(string DestFilename,string SrcFilename,bool bReplace/*=true*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	///<summary>MoveFile</summary>
	public static bool MoveFile(string DestFilename,string SrcFilename,bool bReplace/*=true*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	///<summary>Get the users directory.  Platform specific (usually something like MyDocuments or the users home directory</summary>
	public static string GetUserDirectory() { return default; }
}

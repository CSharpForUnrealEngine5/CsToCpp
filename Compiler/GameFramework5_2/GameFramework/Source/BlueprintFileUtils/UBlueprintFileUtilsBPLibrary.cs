#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintFileUtilsBPLibrary.h")]
public partial class UBlueprintFileUtilsBPLibrary : UBlueprintFunctionLibrary {
// BlueprintFileUtilsBPLibrary
	public bool FindFiles(string Directory,TArray<string> FoundFiles,string FileExtension/*=TEXT("")*/) { return default; }
	public bool FindRecursive(string StartDirectory,TArray<string> FoundPaths,string Wildcard/*=TEXT("")*/,bool bFindFiles/*=true*/,bool bFindDirectories/*=false*/) { return default; }
	public bool FileExists(string Filename) { return default; }
	public bool DirectoryExists(string Directory) { return default; }
	public bool MakeDirectory(string Path,bool bCreateTree/*=false*/) { return default; }
	public bool DeleteDirectory(string Directory,bool bMustExist/*=false*/,bool bDeleteRecursively/*=false*/) { return default; }
	public bool DeleteFile(string Filename,bool bMustExist/*=false*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	public bool CopyFile(string DestFilename,string SrcFilename,bool bReplace/*=true*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	public bool MoveFile(string DestFilename,string SrcFilename,bool bReplace/*=true*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	public string GetUserDirectory() { return default; }
}

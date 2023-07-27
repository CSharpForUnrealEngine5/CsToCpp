#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintFileUtilsBPLibrary.h")]
public partial class UBlueprintFileUtilsBPLibrary : UBlueprintFunctionLibrary {
// BlueprintFileUtilsBPLibrary
	public static bool FindFiles(string Directory,TArray<string> FoundFiles,string FileExtension/*=TEXT("")*/) { return default; }
	public static bool FindRecursive(string StartDirectory,TArray<string> FoundPaths,string Wildcard/*=TEXT("")*/,bool bFindFiles/*=true*/,bool bFindDirectories/*=false*/) { return default; }
	public static bool FileExists(string Filename) { return default; }
	public static bool DirectoryExists(string Directory) { return default; }
	public static bool MakeDirectory(string Path,bool bCreateTree/*=false*/) { return default; }
	public static bool DeleteDirectory(string Directory,bool bMustExist/*=false*/,bool bDeleteRecursively/*=false*/) { return default; }
	public static bool DeleteFile(string Filename,bool bMustExist/*=false*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	public static bool CopyFile(string DestFilename,string SrcFilename,bool bReplace/*=true*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	public static bool MoveFile(string DestFilename,string SrcFilename,bool bReplace/*=true*/,bool bEvenIfReadOnly/*=false*/) { return default; }
	public static string GetUserDirectory() { return default; }
}

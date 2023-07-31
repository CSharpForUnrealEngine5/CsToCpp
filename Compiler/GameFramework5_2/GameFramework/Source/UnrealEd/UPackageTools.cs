#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PackageTools.h")]
public partial class UPackageTools : UObject {
	///<summary>Replaces all invalid package name characters with _</summary>
	public static string SanitizePackageName(string InPackageName) { return default; }
	///<summary>Converts a long package name to a file name.</summary>
	public static string PackageNameToFilename(string PackageName,string Extension/*=TEXT("")*/) { return default; }
	///<summary>Tries to convert a given relative or absolute filename to a long package name or path starting with a root like /Game</summary>
	public static string FilenameToPackageName(string Filename) { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class responsible for loading HLSL text and parsing any metadata available.</summary>
[CppInclude("ComputeFramework/ComputeSourceFromText.h")]
public partial class UComputeSourceFromText : UComputeSource {
	public static UClass StaticClass() {return default;}
	///<summary>Filepath to the source file containing the kernel entry points and all options for parsing.</summary>
	public FFilePath SourceFile;
}

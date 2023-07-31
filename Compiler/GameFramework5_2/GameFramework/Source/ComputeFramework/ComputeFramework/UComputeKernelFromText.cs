#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class responsible for loading HLSL text and parsing the options available.</summary>
[CppInclude("ComputeFramework/ComputeKernelFromText.h")]
public partial class UComputeKernelFromText : UComputeKernelSource {
	///<summary>Filepath to the source file containing the kernel entry points and all options for parsing.</summary>
	public FFilePath SourceFile;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class responsible for loading HLSL text and parsing the options available.</summary>
[CppInclude("ComputeFramework/ComputeKernelFromText.h")]
public partial class UComputeKernelFromText : UComputeKernelSource {
	public static UClass StaticClass() {return default;}
	///<summary>Filepath to the source file containing the kernel entry points and all options for parsing.</summary>
	public FFilePath SourceFile;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class representing the source for a UComputeKernel</summary>
[CppInclude("ComputeFramework/ComputeKernelSource.h")]
public partial class UComputeKernelSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Kernel entry point.</summary>
	public string EntryPoint;
	///<summary>Kernel group size.</summary>
	public FIntVector GroupSize;
	///<summary>Base permutations exposed by the kernel. These will be extended by further permutations declared in any linked data providers.</summary>
	public FComputeKernelPermutationSet PermutationSet;
	///<summary>Base environment defines for kernel compilation. These will be extended by further defines declared in any linked data providers.</summary>
	public FComputeKernelDefinitionSet DefinitionsSet;
	///<summary>An array of additional independent source assets that the kernel source depends on.</summary>
	public TArray<UComputeSource> AdditionalSources;
	///<summary>Named external inputs for the kernel. These must be fulfilled by linked data providers.</summary>
	public TArray<FShaderFunctionDefinition> ExternalInputs;
	///<summary>Named external outputs for the kernel. These must be fulfilled by linked data providers.</summary>
	public TArray<FShaderFunctionDefinition> ExternalOutputs;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ComputeKernelSource.h")]
///<summary>Class representing the source for a UComputeKernel</summary>
public partial class UComputeKernelSource : UObject {
// ComputeKernelSource
	public string EntryPoint;
	public FIntVector GroupSize;
	public FComputeKernelPermutationSet PermutationSet;
	public FComputeKernelDefinitionSet DefinitionsSet;
	public TArray<UComputeSource> AdditionalSources;
	public TArray<FShaderFunctionDefinition> ExternalInputs;
	public TArray<FShaderFunctionDefinition> ExternalOutputs;
}

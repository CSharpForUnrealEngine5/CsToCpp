#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ComputeKernel.h")]
///<summary>Base class representing a kernel that will be run as a shader on the GPU.</summary>
public partial class UComputeKernel : UObject {
// ComputeKernel
	public UComputeKernelSource KernelSource;
	public int KernelFlags;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class representing a kernel that will be run as a shader on the GPU.</summary>
[CppInclude("ComputeFramework/ComputeKernel.h")]
public partial class UComputeKernel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The compute kernel source asset.</summary>
	public UComputeKernelSource KernelSource;
	///<summary>Specifying certain memory access flags allows for optimizations such as kernel fusing.</summary>
	public int KernelFlags;
}

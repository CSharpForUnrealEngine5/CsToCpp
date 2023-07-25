#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComputeFramework/ComputeKernel.h")]
///<summary>Flags that convey kernel behavior to aid compilation/optimizations.</summary>
public enum EComputeKernelFlags {
	IsDefaultKernel=-1,
	IsolatedMemoryWrites=-1,
}

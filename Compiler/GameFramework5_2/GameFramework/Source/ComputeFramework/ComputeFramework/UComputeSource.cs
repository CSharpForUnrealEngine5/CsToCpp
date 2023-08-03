#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class representing some source for inclusion in a UComputeKernel.</summary>
[CppInclude("ComputeFramework/ComputeSource.h")]
public partial class UComputeSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of additional source objects. This allows us to specify source dependencies.</summary>
	public TArray<UComputeSource> AdditionalSources;
}

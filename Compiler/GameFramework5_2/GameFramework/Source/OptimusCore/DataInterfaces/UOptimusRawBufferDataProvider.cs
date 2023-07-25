#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceRawBuffer.h")]
///<summary>Compute Framework Data Provider for a transient buffer.</summary>
public partial class UOptimusRawBufferDataProvider : UComputeDataProvider {
// OptimusRawBufferDataProvider
	public TWeakObjectPtr<UActorComponent> Component;
	public TWeakObjectPtr<UOptimusComponentSource> ComponentSource;
	public FOptimusDataDomain DataDomain;
	public int ElementStride;
	public int RawStride;
}

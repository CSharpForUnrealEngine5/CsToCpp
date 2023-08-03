#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for a transient buffer.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceRawBuffer.h")]
public partial class UOptimusRawBufferDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>The skinned mesh component that governs the sizing and LOD of this buffer</summary>
	public TWeakObjectPtr<UActorComponent> Component;
	///<summary>ComponentSource</summary>
	public TWeakObjectPtr<UOptimusComponentSource> ComponentSource;
	///<summary>The data domain this buffer covers</summary>
	public FOptimusDataDomain DataDomain;
	///<summary>ElementStride</summary>
	public int ElementStride;
	///<summary>RawStride</summary>
	public int RawStride;
}

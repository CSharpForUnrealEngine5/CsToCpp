#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/DIFleshDeformer.h")]
///<summary>Compute Framework Data Provider for reading skeletal mesh.</summary>
public partial class UDIFleshDeformerDataProvider : UComputeDataProvider {
// DIFleshDeformerDataProvider
	public USkinnedMeshComponent SkinnedMesh;
	public UStaticMeshComponent StaticMesh;
	public UFleshComponent FleshMesh;
	public FFleshDeformerParameters FleshDeformerParameters;
}

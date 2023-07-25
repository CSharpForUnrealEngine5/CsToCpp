#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FMassInstancedStaticMeshInfo {
// MassInstancedStaticMeshInfo
	public FStaticMeshInstanceVisualizationDesc Desc;
	public TArray<UInstancedStaticMeshComponent> InstancedStaticMeshComponents;
	public TArray<FMassLODSignificanceRange> LODSignificanceRanges;
}

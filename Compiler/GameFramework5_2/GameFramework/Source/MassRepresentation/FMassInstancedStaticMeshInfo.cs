namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FMassInstancedStaticMeshInfo {
	public FStaticMeshInstanceVisualizationDesc Desc;
	public TArray<UInstancedStaticMeshComponent> InstancedStaticMeshComponents;
	public TArray<FMassLODSignificanceRange> LODSignificanceRanges;
}

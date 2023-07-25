#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FStaticMeshInstanceVisualizationMeshDesc {
// StaticMeshInstanceVisualizationMeshDesc
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> MaterialOverrides;
	public float MinLODSignificance;
	public float MaxLODSignificance;
	public bool bCastShadows;
	public byte Mobility;
}

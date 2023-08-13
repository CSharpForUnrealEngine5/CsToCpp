namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FStaticMeshInstanceVisualizationMeshDesc {
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> MaterialOverrides;
	public float MinLODSignificance;
	public float MaxLODSignificance;
	public bool bCastShadows;
	public EComponentMobility Mobility;
}

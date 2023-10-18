namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FMassStaticMeshInstanceVisualizationMeshDesc {
	public UStaticMesh Mesh;
	public TArray<UMaterialInterface> MaterialOverrides;
	public float MinLODSignificance;
	public float MaxLODSignificance;
	public bool bCastShadows;
	public UClass ISMComponentClass;
}

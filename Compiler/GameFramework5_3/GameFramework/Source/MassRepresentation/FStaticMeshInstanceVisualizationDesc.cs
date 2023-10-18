namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FStaticMeshInstanceVisualizationDesc {
	public TArray<FMassStaticMeshInstanceVisualizationMeshDesc> Meshes;
	public bool bUseTransformOffset;
	public FTransform TransformOffset;
}

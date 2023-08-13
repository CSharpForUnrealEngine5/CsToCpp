namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FStaticMeshInstanceVisualizationDesc {
	public TArray<FStaticMeshInstanceVisualizationMeshDesc> Meshes;
	public bool bUseTransformOffset;
	public FTransform TransformOffset;
}

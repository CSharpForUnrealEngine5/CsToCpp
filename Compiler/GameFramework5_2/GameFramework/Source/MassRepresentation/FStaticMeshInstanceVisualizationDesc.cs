#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationTypes.h")]
public partial struct FStaticMeshInstanceVisualizationDesc {
// StaticMeshInstanceVisualizationDesc
	public TArray<FStaticMeshInstanceVisualizationMeshDesc> Meshes;
	public bool bUseTransformOffset;
	public FTransform TransformOffset;
}

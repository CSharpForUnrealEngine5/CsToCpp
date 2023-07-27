#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSamplingFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSamplingFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSamplingFunctions
	public static UDynamicMesh ComputePointSampling(UDynamicMesh TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,TArray<FTransform> Samples,FGeometryScriptIndexList TriangleIDs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputeNonUniformPointSampling(UDynamicMesh TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,FGeometryScriptNonUniformPointSamplingOptions NonUniformOptions,TArray<FTransform> Samples,TArray<double> SampleRadii,FGeometryScriptIndexList TriangleIDs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	public static UDynamicMesh ComputeVertexWeightedPointSampling(UDynamicMesh TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,FGeometryScriptNonUniformPointSamplingOptions NonUniformOptions,FGeometryScriptScalarList VertexWeights,TArray<FTransform> Samples,TArray<double> SampleRadii,FGeometryScriptIndexList TriangleIDs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}

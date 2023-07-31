#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSamplingFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSamplingFunctions : UBlueprintFunctionLibrary {
	///<summary>Compute a set of sample points lying on the surface of TargetMesh based on the provided sampling Options.</summary>
	public static UDynamicMesh ComputePointSampling(UDynamicMesh TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,TArray<FTransform> Samples,FGeometryScriptIndexList TriangleIDs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute a set of sample points lying on the surface of TargetMesh based on the provided sampling Options and NonUniformOptions.</summary>
	public static UDynamicMesh ComputeNonUniformPointSampling(UDynamicMesh TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,FGeometryScriptNonUniformPointSamplingOptions NonUniformOptions,TArray<FTransform> Samples,TArray<double> SampleRadii,FGeometryScriptIndexList TriangleIDs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Compute a set of sample points lying on the surface of TargetMesh based on the provided sampling Options and NonUniformOptions.</summary>
	public static UDynamicMesh ComputeVertexWeightedPointSampling(UDynamicMesh TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,FGeometryScriptNonUniformPointSamplingOptions NonUniformOptions,FGeometryScriptScalarList VertexWeights,TArray<FTransform> Samples,TArray<double> SampleRadii,FGeometryScriptIndexList TriangleIDs,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}

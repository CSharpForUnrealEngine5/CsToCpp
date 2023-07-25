#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSamplingFunctions.h")]
public partial class UGeometryScriptLibrary_MeshSamplingFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshSamplingFunctions
	public UObject ComputePointSampling(UObject TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,TArray<FTransform> Samples,FGeometryScriptIndexList TriangleIDs,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputeNonUniformPointSampling(UObject TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,FGeometryScriptNonUniformPointSamplingOptions NonUniformOptions,TArray<FTransform> Samples,TArray<double> SampleRadii,FGeometryScriptIndexList TriangleIDs,UObject Debug/*=nullptr*/) { return default; }
	public UObject ComputeVertexWeightedPointSampling(UObject TargetMesh,FGeometryScriptMeshPointSamplingOptions Options,FGeometryScriptNonUniformPointSamplingOptions NonUniformOptions,FGeometryScriptScalarList VertexWeights,TArray<FTransform> Samples,TArray<double> SampleRadii,FGeometryScriptIndexList TriangleIDs,UObject Debug/*=nullptr*/) { return default; }
}

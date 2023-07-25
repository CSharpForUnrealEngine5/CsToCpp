#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshComparisonFunctions.h")]
public partial class UGeometryScriptLibrary_MeshComparisonFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshComparisonFunctions
	public UObject IsSameMeshAs(UObject TargetMesh,UObject OtherMesh,FGeometryScriptIsSameMeshOptions Options,bool bIsSameMesh,UObject Debug/*=nullptr*/) { return default; }
	public UObject MeasureDistancesBetweenMeshes(UObject TargetMesh,UObject OtherMesh,FGeometryScriptMeasureMeshDistanceOptions Options,double MaxDistance,double MinDistance,double AverageDistance,double RootMeanSqrDeviation,UObject Debug/*=nullptr*/) { return default; }
	public UObject IsIntersectingMesh(UObject TargetMesh,FTransform TargetTransform,UObject OtherMesh,FTransform OtherTransform,bool bIsIntersecting,UObject Debug/*=nullptr*/) { return default; }
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshComparisonFunctions.h")]
public partial class UGeometryScriptLibrary_MeshComparisonFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if the two input meshes are equivalent under the comparisons defined by the input options.</summary>
	public static UDynamicMesh IsSameMeshAs(UDynamicMesh TargetMesh,UDynamicMesh OtherMesh,FGeometryScriptIsSameMeshOptions Options,bool bIsSameMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Measures the min/max and average closest-point distances between two meshes.</summary>
	public static UDynamicMesh MeasureDistancesBetweenMeshes(UDynamicMesh TargetMesh,UDynamicMesh OtherMesh,FGeometryScriptMeasureMeshDistanceOptions Options,double MaxDistance,double MinDistance,double AverageDistance,double RootMeanSqrDeviation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Returns true if the two input meshes (with optional transforms) are geometrically intersecting.</summary>
	public static UDynamicMesh IsIntersectingMesh(UDynamicMesh TargetMesh,FTransform TargetTransform,UDynamicMesh OtherMesh,FTransform OtherTransform,bool bIsIntersecting,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}

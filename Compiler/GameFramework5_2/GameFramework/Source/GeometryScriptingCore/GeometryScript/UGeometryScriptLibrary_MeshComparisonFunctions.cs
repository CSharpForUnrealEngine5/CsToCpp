namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshComparisonFunctions.h")]
public partial class UGeometryScriptLibrary_MeshComparisonFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>IsSameMeshAs</summary>
	public static UDynamicMesh IsSameMeshAs(UDynamicMesh TargetMesh,UDynamicMesh OtherMesh,FGeometryScriptIsSameMeshOptions Options,bool bIsSameMesh,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>MeasureDistancesBetweenMeshes</summary>
	public static UDynamicMesh MeasureDistancesBetweenMeshes(UDynamicMesh TargetMesh,UDynamicMesh OtherMesh,FGeometryScriptMeasureMeshDistanceOptions Options,double MaxDistance,double MinDistance,double AverageDistance,double RootMeanSqrDeviation,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>IsIntersectingMesh</summary>
	public static UDynamicMesh IsIntersectingMesh(UDynamicMesh TargetMesh,FTransform TargetTransform,UDynamicMesh OtherMesh,FTransform OtherTransform,bool bIsIntersecting,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}

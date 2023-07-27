#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolyPathFunctions.h")]
public partial class UGeometryScriptLibrary_PolyPathFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_PolyPathFunctions
	public static int GetPolyPathNumVertices(FGeometryScriptPolyPath PolyPath) { return default; }
	public static int GetPolyPathLastIndex(FGeometryScriptPolyPath PolyPath) { return default; }
	public static FVector GetPolyPathVertex(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex) { return default; }
	public static FVector GetPolyPathTangent(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex) { return default; }
	public static double GetPolyPathArcLength(FGeometryScriptPolyPath PolyPath) { return default; }
	public static int GetNearestVertexIndex(FGeometryScriptPolyPath PolyPath,FVector Point) { return default; }
	public static FGeometryScriptPolyPath FlattenTo2DOnAxis(FGeometryScriptPolyPath PolyPath,EGeometryScriptAxis DropAxis/*=EGeometryScriptAxis.Z*/) { return default; }
	public static FGeometryScriptPolyPath CreateCirclePath3D(FTransform Transform,float Radius/*=10f*/,int NumPoints/*=10*/) { return default; }
	public static FGeometryScriptPolyPath CreateArcPath3D(FTransform Transform,float Radius/*=10f*/,int NumPoints/*=10*/,float StartAngle/*=0f*/,float EndAngle/*=90f*/) { return default; }
	public static FGeometryScriptPolyPath CreateCirclePath2D(FVector2D Center/*=new FVector2D(0,0)*/,float Radius/*=10f*/,int NumPoints/*=10*/) { return default; }
	public static FGeometryScriptPolyPath CreateArcPath2D(FVector2D Center/*=new FVector2D(0,0)*/,float Radius/*=10f*/,int NumPoints/*=10*/,float StartAngle/*=0f*/,float EndAngle/*=90f*/) { return default; }
	public static void ConvertSplineToPolyPath(USplineComponent Spline,FGeometryScriptPolyPath PolyPath,FGeometryScriptSplineSamplingOptions SamplingOptions) {}
	public static void SampleSplineToTransforms(USplineComponent Spline,TArray<FTransform> Frames,TArray<double> FrameTimes,FGeometryScriptSplineSamplingOptions SamplingOptions,FTransform RelativeTransform,bool bIncludeScale/*=true*/) {}
	public static void ConvertPolyPathToArray(FGeometryScriptPolyPath PolyPath,TArray<FVector> VertexArray) {}
	public static void ConvertArrayToPolyPath(TArray<FVector> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	public static void ConvertPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath,TArray<FVector2D> VertexArray) {}
	public static void ConvertArrayOfVector2DToPolyPath(TArray<FVector2D> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	public static TArray<FVector> Conv_GeometryScriptPolyPathToArray(FGeometryScriptPolyPath PolyPath) { return default; }
	public static TArray<FVector2D> Conv_GeometryScriptPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath) { return default; }
	public static FGeometryScriptPolyPath Conv_ArrayToGeometryScriptPolyPath(TArray<FVector> PathVertices) { return default; }
	public static FGeometryScriptPolyPath Conv_ArrayOfVector2DToGeometryScriptPolyPath(TArray<FVector2D> PathVertices) { return default; }
}

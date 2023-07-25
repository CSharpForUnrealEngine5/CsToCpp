#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolyPathFunctions.h")]
public partial class UGeometryScriptLibrary_PolyPathFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_PolyPathFunctions
	public int GetPolyPathNumVertices(FGeometryScriptPolyPath PolyPath) { return default; }
	public int GetPolyPathLastIndex(FGeometryScriptPolyPath PolyPath) { return default; }
	public FVector GetPolyPathVertex(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex) { return default; }
	public FVector GetPolyPathTangent(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex) { return default; }
	public double GetPolyPathArcLength(FGeometryScriptPolyPath PolyPath) { return default; }
	public int GetNearestVertexIndex(FGeometryScriptPolyPath PolyPath,FVector Point) { return default; }
	public FGeometryScriptPolyPath FlattenTo2DOnAxis(FGeometryScriptPolyPath PolyPath,EGeometryScriptAxis DropAxis/*=EGeometryScriptAxis.Z*/) { return default; }
	public FGeometryScriptPolyPath CreateCirclePath3D(FTransform Transform,float Radius/*=10f*/,int NumPoints/*=10*/) { return default; }
	public FGeometryScriptPolyPath CreateArcPath3D(FTransform Transform,float Radius/*=10f*/,int NumPoints/*=10*/,float StartAngle/*=0f*/,float EndAngle/*=90f*/) { return default; }
	public FGeometryScriptPolyPath CreateCirclePath2D(FVector2D Center/*=new FVector2D(0,0)*/,float Radius/*=10f*/,int NumPoints/*=10*/) { return default; }
	public FGeometryScriptPolyPath CreateArcPath2D(FVector2D Center/*=new FVector2D(0,0)*/,float Radius/*=10f*/,int NumPoints/*=10*/,float StartAngle/*=0f*/,float EndAngle/*=90f*/) { return default; }
	public void ConvertSplineToPolyPath(UObject Spline,FGeometryScriptPolyPath PolyPath,FGeometryScriptSplineSamplingOptions SamplingOptions) {}
	public void SampleSplineToTransforms(UObject Spline,TArray<FTransform> Frames,TArray<double> FrameTimes,FGeometryScriptSplineSamplingOptions SamplingOptions,FTransform RelativeTransform,bool bIncludeScale/*=true*/) {}
	public void ConvertPolyPathToArray(FGeometryScriptPolyPath PolyPath,TArray<FVector> VertexArray) {}
	public void ConvertArrayToPolyPath(TArray<FVector> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	public void ConvertPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath,TArray<FVector2D> VertexArray) {}
	public void ConvertArrayOfVector2DToPolyPath(TArray<FVector2D> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	public TArray<FVector> Conv_GeometryScriptPolyPathToArray(FGeometryScriptPolyPath PolyPath) { return default; }
	public TArray<FVector2D> Conv_GeometryScriptPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath) { return default; }
	public FGeometryScriptPolyPath Conv_ArrayToGeometryScriptPolyPath(TArray<FVector> PathVertices) { return default; }
	public FGeometryScriptPolyPath Conv_ArrayOfVector2DToGeometryScriptPolyPath(TArray<FVector2D> PathVertices) { return default; }
}

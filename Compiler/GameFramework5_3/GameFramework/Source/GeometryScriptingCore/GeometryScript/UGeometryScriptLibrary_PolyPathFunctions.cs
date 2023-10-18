namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolyPathFunctions.h")]
public partial class UGeometryScriptLibrary_PolyPathFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the number of vertices in the the PolyPath.</summary>
	public static int GetPolyPathNumVertices(FGeometryScriptPolyPath PolyPath) { return default; }
	///<summary>Returns the index of the last vertex in the PolyPath.</summary>
	public static int GetPolyPathLastIndex(FGeometryScriptPolyPath PolyPath) { return default; }
	///<summary>Returns the 3D position of the requested vertex in the PolyPath.</summary>
	public static FVector GetPolyPathVertex(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex) { return default; }
	///<summary>Returns the local tangent vector of the PolyPath at the specified vertex index.</summary>
	public static FVector GetPolyPathTangent(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex) { return default; }
	///<summary>Returns the length of the PolyPath.</summary>
	public static double GetPolyPathArcLength(FGeometryScriptPolyPath PolyPath) { return default; }
	///<summary>Find the index of the vertex closest to a given point.  Returns -1 if the PolyPath has no vertices.</summary>
	public static int GetNearestVertexIndex(FGeometryScriptPolyPath PolyPath,FVector Point) { return default; }
	///<summary>Create a 2D, flattened copy of the path by dropping the given axis, and using the other two coordinates as the new X, Y coordinates.</summary>
	public static FGeometryScriptPolyPath FlattenTo2DOnAxis(FGeometryScriptPolyPath PolyPath,EGeometryScriptAxis DropAxis/*=EGeometryScriptAxis.Z*/) { return default; }
	///<summary>Create a closed circle around the origin on the XY plane, then transformed by Transform.</summary>
	public static FGeometryScriptPolyPath CreateCirclePath3D(FTransform Transform,float Radius/*=10f*/,int NumPoints/*=10*/) { return default; }
	///<summary>Create an open arc around the origin on the XY plane, then transformed by Transform.</summary>
	public static FGeometryScriptPolyPath CreateArcPath3D(FTransform Transform,float Radius/*=10f*/,int NumPoints/*=10*/,float StartAngle/*=0f*/,float EndAngle/*=90f*/) { return default; }
	///<summary>Create a closed circle on the XY plane around the given Center.</summary>
	public static FGeometryScriptPolyPath CreateCirclePath2D(FVector2D Center/*=new FVector2D(0,0)*/,float Radius/*=10f*/,int NumPoints/*=10*/) { return default; }
	///<summary>Create an open arc on the XY plane around the given Center.</summary>
	public static FGeometryScriptPolyPath CreateArcPath2D(FVector2D Center/*=new FVector2D(0,0)*/,float Radius/*=10f*/,int NumPoints/*=10*/,float StartAngle/*=0f*/,float EndAngle/*=90f*/) { return default; }
	///<summary>Sample positions from a USplineComponent into a PolyPath, based on the given SamplingOptions</summary>
	public static void ConvertSplineToPolyPath(USplineComponent Spline,FGeometryScriptPolyPath PolyPath,FGeometryScriptSplineSamplingOptions SamplingOptions) {}
	///<summary>Sample a USplineComponent into a list of FTransforms, based on the given SamplingOptions.</summary>
	public static void SampleSplineToTransforms(USplineComponent Spline,TArray<FTransform> Frames,TArray<double> FrameTimes,FGeometryScriptSplineSamplingOptions SamplingOptions,FTransform RelativeTransform,bool bIncludeScale/*=true*/) {}
	///<summary>Populates an array of 3D vectors with the PolyPath vertex locations.</summary>
	public static void ConvertPolyPathToArray(FGeometryScriptPolyPath PolyPath,TArray<FVector> VertexArray) {}
	///<summary>Creates a PolyPath from an array of 3D position vectors.</summary>
	public static void ConvertArrayToPolyPath(TArray<FVector> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	///<summary>Creates an array of 2D Vectors with the PolyPath vertex locations projected onto the XY plane.</summary>
	public static void ConvertPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath,TArray<FVector2D> VertexArray) {}
	///<summary>Creates a PolyPath from an array of 2D position vectors. The Z-coordinate of the corresponding PolyPath vertices will be zero.</summary>
	public static void ConvertArrayOfVector2DToPolyPath(TArray<FVector2D> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	///<summary>Returns an array of 3D vectors with the PolyPath vertex locations.</summary>
	public static TArray<FVector> Conv_GeometryScriptPolyPathToArray(FGeometryScriptPolyPath PolyPath) { return default; }
	///<summary>Returns an array of 2D Vectors with the PolyPath vertex locations projected onto the XY plane.</summary>
	public static TArray<FVector2D> Conv_GeometryScriptPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath) { return default; }
	///<summary>Returns a PolyPath created from an array of 3D position vectors.</summary>
	public static FGeometryScriptPolyPath Conv_ArrayToGeometryScriptPolyPath(TArray<FVector> PathVertices) { return default; }
	///<summary>Returns a PolyPath created from an array of 2D position vectors. The Z-coordinate of the corresponding PolyPath vertices will be zero.</summary>
	public static FGeometryScriptPolyPath Conv_ArrayOfVector2DToGeometryScriptPolyPath(TArray<FVector2D> PathVertices) { return default; }
}

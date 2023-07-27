#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_BoxFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_BoxFunctions
	public static FBox MakeBoxFromCenterSize(FVector Center,FVector Dimensions) { return default; }
	public static FBox MakeBoxFromCenterExtents(FVector Center,FVector Extents) { return default; }
	public static void GetBoxCenterSize(FBox Box,FVector Center,FVector Dimensions) {}
	public static FVector GetBoxCorner(FBox Box,int CornerIndex) { return default; }
	public static FVector GetBoxFaceCenter(FBox Box,int FaceIndex,FVector FaceNormal) { return default; }
	public static void GetBoxVolumeArea(FBox Box,double Volume,double SurfaceArea) {}
	public static FBox GetExpandedBox(FBox Box,FVector ExpandBy) { return default; }
	public static FBox GetTransformedBox(FBox Box,FTransform Transform) { return default; }
	public static bool TestBoxBoxIntersection(FBox Box1,FBox Box2) { return default; }
	public static FBox FindBoxBoxIntersection(FBox Box1,FBox Box2,bool bIsIntersecting) { return default; }
	public static double GetBoxBoxDistance(FBox Box1,FBox Box2) { return default; }
	public static bool TestPointInsideBox(FBox Box,FVector Point,bool bConsiderOnBoxAsInside/*=true*/) { return default; }
	public static FVector FindClosestPointOnBox(FBox Box,FVector Point,bool bIsInside) { return default; }
	public static double GetBoxPointDistance(FBox Box,FVector Point) { return default; }
	public static bool TestBoxSphereIntersection(FBox Box,FVector SphereCenter,double SphereRadius) { return default; }
}

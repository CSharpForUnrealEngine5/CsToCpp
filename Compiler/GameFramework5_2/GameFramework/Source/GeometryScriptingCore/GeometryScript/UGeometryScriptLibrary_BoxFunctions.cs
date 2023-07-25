#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_BoxFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_BoxFunctions
	public FBox MakeBoxFromCenterSize(FVector Center,FVector Dimensions) { return default; }
	public FBox MakeBoxFromCenterExtents(FVector Center,FVector Extents) { return default; }
	public void GetBoxCenterSize(FBox Box,FVector Center,FVector Dimensions) {}
	public FVector GetBoxCorner(FBox Box,int CornerIndex) { return default; }
	public FVector GetBoxFaceCenter(FBox Box,int FaceIndex,FVector FaceNormal) { return default; }
	public void GetBoxVolumeArea(FBox Box,double Volume,double SurfaceArea) {}
	public FBox GetExpandedBox(FBox Box,FVector ExpandBy) { return default; }
	public FBox GetTransformedBox(FBox Box,FTransform Transform) { return default; }
	public bool TestBoxBoxIntersection(FBox Box1,FBox Box2) { return default; }
	public FBox FindBoxBoxIntersection(FBox Box1,FBox Box2,bool bIsIntersecting) { return default; }
	public double GetBoxBoxDistance(FBox Box1,FBox Box2) { return default; }
	public bool TestPointInsideBox(FBox Box,FVector Point,bool bConsiderOnBoxAsInside/*=true*/) { return default; }
	public FVector FindClosestPointOnBox(FBox Box,FVector Point,bool bIsInside) { return default; }
	public double GetBoxPointDistance(FBox Box,FVector Point) { return default; }
	public bool TestBoxSphereIntersection(FBox Box,FVector SphereCenter,double SphereRadius) { return default; }
}

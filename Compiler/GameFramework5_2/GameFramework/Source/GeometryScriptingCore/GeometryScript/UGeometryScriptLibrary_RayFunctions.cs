#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_RayFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_RayFunctions
	public static FRay MakeRayFromPoints(FVector A,FVector B) { return default; }
	public static FRay MakeRayFromPointDirection(FVector Origin,FVector Direction,bool bDirectionIsNormalized/*=true*/) { return default; }
	public static FRay GetTransformedRay(FRay Ray,FTransform Transform,bool bInvert/*=false*/) { return default; }
	public static FVector GetRayPoint(FRay Ray,double Distance) { return default; }
	public static void GetRayStartEnd(FRay Ray,double StartDistance,double EndDistance,FVector StartPoint,FVector EndPoint) {}
	public static double GetRayParameter(FRay Ray,FVector Point) { return default; }
	public static double GetRayPointDistance(FRay Ray,FVector Point) { return default; }
	public static FVector GetRayClosestPoint(FRay Ray,FVector Point) { return default; }
	public static bool GetRaySphereIntersection(FRay Ray,FVector SphereCenter,double SphereRadius,double Distance1,double Distance2) { return default; }
	public static bool GetRayBoxIntersection(FRay Ray,FBox Box,double HitDistance) { return default; }
	public static bool GetRayPlaneIntersection(FRay Ray,FPlane Plane,double HitDistance) { return default; }
	public static double GetRayLineClosestPoint(FRay Ray,FVector LineOrigin,FVector LineDirection,double RayParameter,FVector RayPoint,double LineParameter,FVector LinePoint) { return default; }
	public static double GetRaySegmentClosestPoint(FRay Ray,FVector SegStartPoint,FVector SegEndPoint,double RayParameter,FVector RayPoint,FVector SegPoint) { return default; }
}

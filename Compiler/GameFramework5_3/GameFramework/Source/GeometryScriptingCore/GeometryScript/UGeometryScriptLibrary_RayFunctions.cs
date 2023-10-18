namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_RayFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create a Ray from two points, placing the Origin at A and the Direction as Normalize(B-A)</summary>
	public static FRay MakeRayFromPoints(FVector A,FVector B) { return default; }
	///<summary>Create a Ray from an Origin and Direction, with optionally non-normalized Direction</summary>
	public static FRay MakeRayFromPointDirection(FVector Origin,FVector Direction,bool bDirectionIsNormalized/*=true*/) { return default; }
	///<summary>Apply the given Transform to the given Ray, or optionally the Transform Inverse, and return the new transformed Ray</summary>
	public static FRay GetTransformedRay(FRay Ray,FTransform Transform,bool bInvert/*=false*/) { return default; }
	///<summary>Get a Point at the given Distance along the Ray (Origin + Distance*Direction)</summary>
	public static FVector GetRayPoint(FRay Ray,double Distance) { return default; }
	///<summary>Get two points along the ray.</summary>
	public static void GetRayStartEnd(FRay Ray,double StartDistance,double EndDistance,FVector StartPoint,FVector EndPoint) {}
	///<summary>Project the given Point onto the closest point along the Ray, and return the Ray Parameter/Distance at that Point</summary>
	public static double GetRayParameter(FRay Ray,FVector Point) { return default; }
	///<summary>Get the distance from Point to the closest point on the Ray</summary>
	public static double GetRayPointDistance(FRay Ray,FVector Point) { return default; }
	///<summary>Get the closest point on the Ray to the given Point</summary>
	public static FVector GetRayClosestPoint(FRay Ray,FVector Point) { return default; }
	///<summary>Check if the Ray intersects a Sphere defined by the SphereCenter and SphereRadius.</summary>
	public static bool GetRaySphereIntersection(FRay Ray,FVector SphereCenter,double SphereRadius,double Distance1,double Distance2) { return default; }
	///<summary>Check if the Ray intersects a Sphere defined by the SphereCenter and SphereRadius.</summary>
	public static bool GetRayBoxIntersection(FRay Ray,FBox Box,double HitDistance) { return default; }
	///<summary>Find the intersection of a Ray and a Plane</summary>
	public static bool GetRayPlaneIntersection(FRay Ray,FPlane Plane,double HitDistance) { return default; }
	///<summary>Compute the pair of closest points on a 3D Ray and Line.</summary>
	public static double GetRayLineClosestPoint(FRay Ray,FVector LineOrigin,FVector LineDirection,double RayParameter,FVector RayPoint,double LineParameter,FVector LinePoint) { return default; }
	///<summary>Compute the pair of closest points on a 3D Ray and Line Segment</summary>
	public static double GetRaySegmentClosestPoint(FRay Ray,FVector SegStartPoint,FVector SegEndPoint,double RayParameter,FVector RayPoint,FVector SegPoint) { return default; }
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_BoxFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create a Box from a Center point and X/Y/Z Dimensions (*not* Extents, which are half-dimensions)</summary>
	public static FBox MakeBoxFromCenterSize(FVector Center,FVector Dimensions) { return default; }
	///<summary>Create a Box from a Center point and X/Y/Z Extents (Extents are half-dimensions)</summary>
	public static FBox MakeBoxFromCenterExtents(FVector Center,FVector Extents) { return default; }
	///<summary>Get the Center point and X/Y/Z Dimensions of a Box (full dimensions, not Extents)</summary>
	public static void GetBoxCenterSize(FBox Box,FVector Center,FVector Dimensions) {}
	///<summary>Get the position of a corner of the Box. Corners are indexed from 0 to 7, using</summary>
	public static FVector GetBoxCorner(FBox Box,int CornerIndex) { return default; }
	///<summary>Get the position of the center of a face of the Box. Faces are indexed from 0 to 5,</summary>
	public static FVector GetBoxFaceCenter(FBox Box,int FaceIndex,FVector FaceNormal) { return default; }
	///<summary>Get the Volume and Surface Area of a Box</summary>
	public static void GetBoxVolumeArea(FBox Box,double Volume,double SurfaceArea) {}
	///<summary>Get the input Box expanded by adding the ExpandBy parameter to both the Min and Max.</summary>
	public static FBox GetExpandedBox(FBox Box,FVector ExpandBy) { return default; }
	///<summary>Apply the input Transform to the corners of the input Box, and return the new Box containing those points</summary>
	public static FBox GetTransformedBox(FBox Box,FTransform Transform) { return default; }
	///<summary>Test if Box1 and Box2 intersect</summary>
	public static bool TestBoxBoxIntersection(FBox Box1,FBox Box2) { return default; }
	///<summary>Find the Box formed by the intersection of Box1 and Box2</summary>
	public static FBox FindBoxBoxIntersection(FBox Box1,FBox Box2,bool bIsIntersecting) { return default; }
	///<summary>Calculate the minimum distance between Box1 and Box2</summary>
	public static double GetBoxBoxDistance(FBox Box1,FBox Box2) { return default; }
	///<summary>Test if a Point is inside the Box, returning true if so, otherwise false</summary>
	public static bool TestPointInsideBox(FBox Box,FVector Point,bool bConsiderOnBoxAsInside/*=true*/) { return default; }
	///<summary>Find the point on the faces of the Box that is closest to the input Point.</summary>
	public static FVector FindClosestPointOnBox(FBox Box,FVector Point,bool bIsInside) { return default; }
	///<summary>Calculate the minimum distance between the Box and the Point</summary>
	public static double GetBoxPointDistance(FBox Box,FVector Point) { return default; }
	///<summary>Check if the Box intersects a Sphere defined by the SphereCenter and SphereRadius</summary>
	public static bool TestBoxSphereIntersection(FBox Box,FVector SphereCenter,double SphereRadius) { return default; }
}

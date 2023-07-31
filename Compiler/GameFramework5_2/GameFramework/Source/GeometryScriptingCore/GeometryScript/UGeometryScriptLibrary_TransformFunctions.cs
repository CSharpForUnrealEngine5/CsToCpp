#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_TransformFunctions : UBlueprintFunctionLibrary {
	///<summary>Create a Transform at the given Location, with the ZAxis vector as the Z axis</summary>
	public static FTransform MakeTransformFromZAxis(FVector Location,FVector ZAxis) { return default; }
	///<summary>Create a Transform at the given Location, with the ZAxis vector as the Z axis</summary>
	public static FTransform MakeTransformFromAxes(FVector Location,FVector ZAxis,FVector TangentAxis,bool bTangentIsX/*=true*/) { return default; }
	///<summary>Get the Vector for the direction of the X/Y/Z axis of the Transform, ie the</summary>
	public static FVector GetTransformAxisVector(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
	///<summary>Get the Ray at the Transform Location aligned with the direction of the X/Y/Z axis of the Transform,</summary>
	public static FRay GetTransformAxisRay(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
	///<summary>Get the Plane at the Transform Location with the Plane Normal aligned with the direction of the X/Y/Z axis of the Transform,</summary>
	public static FPlane GetTransformAxisPlane(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
}

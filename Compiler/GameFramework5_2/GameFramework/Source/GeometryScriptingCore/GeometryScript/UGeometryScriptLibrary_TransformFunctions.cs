#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_TransformFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_TransformFunctions
	public static FTransform MakeTransformFromZAxis(FVector Location,FVector ZAxis) { return default; }
	public static FTransform MakeTransformFromAxes(FVector Location,FVector ZAxis,FVector TangentAxis,bool bTangentIsX/*=true*/) { return default; }
	public static FVector GetTransformAxisVector(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
	public static FRay GetTransformAxisRay(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
	public static FPlane GetTransformAxisPlane(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
}

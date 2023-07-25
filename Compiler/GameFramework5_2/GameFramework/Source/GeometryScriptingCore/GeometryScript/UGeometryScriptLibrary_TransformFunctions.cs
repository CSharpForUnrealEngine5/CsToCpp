#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_TransformFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_TransformFunctions
	public FTransform MakeTransformFromZAxis(FVector Location,FVector ZAxis) { return default; }
	public FTransform MakeTransformFromAxes(FVector Location,FVector ZAxis,FVector TangentAxis,bool bTangentIsX/*=true*/) { return default; }
	public FVector GetTransformAxisVector(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
	public FRay GetTransformAxisRay(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
	public FPlane GetTransformAxisPlane(FTransform Transform,EGeometryScriptAxis Axis/*=EGeometryScriptAxis.X*/) { return default; }
}

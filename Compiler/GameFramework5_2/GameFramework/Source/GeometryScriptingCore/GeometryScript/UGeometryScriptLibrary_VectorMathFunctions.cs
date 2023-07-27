#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/VectorMathFunctions.h")]
public partial class UGeometryScriptLibrary_VectorMathFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_VectorMathFunctions
	public static FGeometryScriptScalarList VectorLength(FGeometryScriptVectorList VectorList) { return default; }
	public static FGeometryScriptScalarList VectorDot(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB) { return default; }
	public static FGeometryScriptVectorList VectorCross(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB) { return default; }
	public static void VectorNormalizeInPlace(FGeometryScriptVectorList VectorList,FVector SetOnFailure/*=FVector.ZeroVector*/) {}
	public static FGeometryScriptVectorList VectorBlend(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) { return default; }
	public static void VectorBlendInPlace(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) {}
	public static FGeometryScriptVectorList ScalarVectorMultiply(FGeometryScriptScalarList ScalarList,FGeometryScriptVectorList VectorList,double ScalarMultiplier/*=1.0*/) { return default; }
	public static void ScalarVectorMultiplyInPlace(FGeometryScriptScalarList ScalarList,FGeometryScriptVectorList VectorList,double ScalarMultiplier/*=1.0*/) {}
	public static FGeometryScriptVectorList ConstantVectorMultiply(double Constant,FGeometryScriptVectorList VectorList) { return default; }
	public static void ConstantVectorMultiplyInPlace(double Constant,FGeometryScriptVectorList VectorList) {}
	public static FGeometryScriptScalarList VectorToScalar(FGeometryScriptVectorList VectorList,double ConstantX/*=1.0*/,double ConstantY/*=0.0*/,double ConstantZ/*=0.0*/) { return default; }
	public static FGeometryScriptScalarList ScalarInvert(FGeometryScriptScalarList ScalarList,double Numerator/*=1.0*/,double SetOnFailure/*=0.0*/,double Epsilon/*=0.0*/) { return default; }
	public static void ScalarInvertInPlace(FGeometryScriptScalarList ScalarList,double Numerator/*=1.0*/,double SetOnFailure/*=0.0*/,double Epsilon/*=0.0*/) {}
	public static FGeometryScriptScalarList ScalarBlend(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) { return default; }
	public static void ScalarBlendInPlace(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) {}
	public static FGeometryScriptScalarList ScalarMultiply(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantMultiplier/*=1.0*/) { return default; }
	public static void ScalarMultiplyInPlace(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantMultiplier/*=1.0*/) {}
	public static FGeometryScriptScalarList ConstantScalarMultiply(double Constant,FGeometryScriptScalarList ScalarList) { return default; }
	public static void ConstantScalarMultiplyInPlace(double Constant,FGeometryScriptScalarList ScalarList) {}
}

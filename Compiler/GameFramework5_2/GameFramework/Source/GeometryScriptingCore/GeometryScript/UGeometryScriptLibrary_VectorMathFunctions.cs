#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/VectorMathFunctions.h")]
public partial class UGeometryScriptLibrary_VectorMathFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_VectorMathFunctions
	public FGeometryScriptScalarList VectorLength(FGeometryScriptVectorList VectorList) { return default; }
	public FGeometryScriptScalarList VectorDot(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB) { return default; }
	public FGeometryScriptVectorList VectorCross(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB) { return default; }
	public void VectorNormalizeInPlace(FGeometryScriptVectorList VectorList,FVector SetOnFailure/*=FVector.ZeroVector*/) {}
	public FGeometryScriptVectorList VectorBlend(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) { return default; }
	public void VectorBlendInPlace(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) {}
	public FGeometryScriptVectorList ScalarVectorMultiply(FGeometryScriptScalarList ScalarList,FGeometryScriptVectorList VectorList,double ScalarMultiplier/*=1.0*/) { return default; }
	public void ScalarVectorMultiplyInPlace(FGeometryScriptScalarList ScalarList,FGeometryScriptVectorList VectorList,double ScalarMultiplier/*=1.0*/) {}
	public FGeometryScriptVectorList ConstantVectorMultiply(double Constant,FGeometryScriptVectorList VectorList) { return default; }
	public void ConstantVectorMultiplyInPlace(double Constant,FGeometryScriptVectorList VectorList) {}
	public FGeometryScriptScalarList VectorToScalar(FGeometryScriptVectorList VectorList,double ConstantX/*=1.0*/,double ConstantY/*=0.0*/,double ConstantZ/*=0.0*/) { return default; }
	public FGeometryScriptScalarList ScalarInvert(FGeometryScriptScalarList ScalarList,double Numerator/*=1.0*/,double SetOnFailure/*=0.0*/,double Epsilon/*=0.0*/) { return default; }
	public void ScalarInvertInPlace(FGeometryScriptScalarList ScalarList,double Numerator/*=1.0*/,double SetOnFailure/*=0.0*/,double Epsilon/*=0.0*/) {}
	public FGeometryScriptScalarList ScalarBlend(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) { return default; }
	public void ScalarBlendInPlace(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) {}
	public FGeometryScriptScalarList ScalarMultiply(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantMultiplier/*=1.0*/) { return default; }
	public void ScalarMultiplyInPlace(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantMultiplier/*=1.0*/) {}
	public FGeometryScriptScalarList ConstantScalarMultiply(double Constant,FGeometryScriptScalarList ScalarList) { return default; }
	public void ConstantScalarMultiplyInPlace(double Constant,FGeometryScriptScalarList ScalarList) {}
}

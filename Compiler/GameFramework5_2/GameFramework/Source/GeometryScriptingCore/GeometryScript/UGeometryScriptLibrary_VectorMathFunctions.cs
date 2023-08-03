#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/VectorMathFunctions.h")]
public partial class UGeometryScriptLibrary_VectorMathFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Compute the length/magnitude of each vector in VectorListA and return in new ScalarList.</summary>
	public static FGeometryScriptScalarList VectorLength(FGeometryScriptVectorList VectorList) { return default; }
	///<summary>Compute the dot-product between each pair of vectors in VectorListA and VectorListB and return in new ScalarList</summary>
	public static FGeometryScriptScalarList VectorDot(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB) { return default; }
	///<summary>Compute the cross-product between each pair of vectors in VectorListA and VectorListB and return in new VectorList</summary>
	public static FGeometryScriptVectorList VectorCross(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB) { return default; }
	///<summary>Normalize each vector in VectorList, and store in VectorList.</summary>
	public static void VectorNormalizeInPlace(FGeometryScriptVectorList VectorList,FVector SetOnFailure/*=FVector.ZeroVector*/) {}
	///<summary>Compute (ConstantA * A) + (ConstantB * B) for each pair of vectors in VectorListA and VectorListB and return in new VectorList.</summary>
	public static FGeometryScriptVectorList VectorBlend(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) { return default; }
	///<summary>Compute (ConstantA * A) + (ConstantB * B) for each pair of vectors in VectorListA and VectorListB, and store in VectorListB</summary>
	public static void VectorBlendInPlace(FGeometryScriptVectorList VectorListA,FGeometryScriptVectorList VectorListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) {}
	///<summary>Compute (ScalarMultiplier * Scalar * Vector) for each scalar/vector pair in the two input lists, and return in a new VectorList.</summary>
	public static FGeometryScriptVectorList ScalarVectorMultiply(FGeometryScriptScalarList ScalarList,FGeometryScriptVectorList VectorList,double ScalarMultiplier/*=1.0*/) { return default; }
	///<summary>Compute (ScalarMultiplier * Scalar * Vector) for each scalar/vector pair in the two input lists, and store in the input VectorList</summary>
	public static void ScalarVectorMultiplyInPlace(FGeometryScriptScalarList ScalarList,FGeometryScriptVectorList VectorList,double ScalarMultiplier/*=1.0*/) {}
	///<summary>Compute (Constant * Vector) for each element in VectorList, and return in a new list</summary>
	public static FGeometryScriptVectorList ConstantVectorMultiply(double Constant,FGeometryScriptVectorList VectorList) { return default; }
	///<summary>Compute (Constant * Vector) for each element in VectorList, and store in VectorList</summary>
	public static void ConstantVectorMultiplyInPlace(double Constant,FGeometryScriptVectorList VectorList) {}
	///<summary>Convert each Vector in VectorList to a Scalar by computing (ConstantX*Vector.X + ConstantY*Vector.Y + ConstantZ*Vector.Z), and return in a new ScalarList.</summary>
	public static FGeometryScriptScalarList VectorToScalar(FGeometryScriptVectorList VectorList,double ConstantX/*=1.0*/,double ConstantY/*=0.0*/,double ConstantZ/*=0.0*/) { return default; }
	///<summary>Compute (Numerator / Scalar) for each element of ScalarList and return in a new ScalarList.</summary>
	public static FGeometryScriptScalarList ScalarInvert(FGeometryScriptScalarList ScalarList,double Numerator/*=1.0*/,double SetOnFailure/*=0.0*/,double Epsilon/*=0.0*/) { return default; }
	///<summary>Compute (Numerator / Scalar) for each element of ScalarList and store in input ScalarList</summary>
	public static void ScalarInvertInPlace(FGeometryScriptScalarList ScalarList,double Numerator/*=1.0*/,double SetOnFailure/*=0.0*/,double Epsilon/*=0.0*/) {}
	///<summary>Compute (ConstantA * A) + (ConstantB * B) for each pair of values in ScalarListA and ScalarListB and return in new ScalarList.</summary>
	public static FGeometryScriptScalarList ScalarBlend(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) { return default; }
	///<summary>Compute (ConstantA * A) + (ConstantB * B) for each pair of values in ScalarListA and ScalarListB and return in ScalarListB.</summary>
	public static void ScalarBlendInPlace(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantA/*=1.0*/,double ConstantB/*=1.0*/) {}
	///<summary>ScalarMultiply</summary>
	public static FGeometryScriptScalarList ScalarMultiply(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantMultiplier/*=1.0*/) { return default; }
	///<summary>ScalarMultiplyInPlace</summary>
	public static void ScalarMultiplyInPlace(FGeometryScriptScalarList ScalarListA,FGeometryScriptScalarList ScalarListB,double ConstantMultiplier/*=1.0*/) {}
	///<summary>ConstantScalarMultiply</summary>
	public static FGeometryScriptScalarList ConstantScalarMultiply(double Constant,FGeometryScriptScalarList ScalarList) { return default; }
	///<summary>ConstantScalarMultiplyInPlace</summary>
	public static void ConstantScalarMultiplyInPlace(double Constant,FGeometryScriptScalarList ScalarList) {}
}

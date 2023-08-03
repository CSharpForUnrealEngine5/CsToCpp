#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AnimationImportTestFunctions.h")]
public partial class UAnimationImportTestFunctions : UImportTestFunctionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the expected number of anim sequences are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedAnimSequenceCount(TArray<UAnimSequence> AnimSequences,int ExpectedNumberOfImportedAnimSequences) { return default; }
	///<summary>Check whether the animation length (second) is as expected</summary>
	public static FInterchangeTestFunctionResult CheckAnimationLength(UAnimSequence AnimSequence,float ExpectedAnimationLength) { return default; }
	///<summary>Check whether the animation frame number is as expected</summary>
	public static FInterchangeTestFunctionResult CheckAnimationFrameNumber(UAnimSequence AnimSequence,int ExpectedFrameNumber) { return default; }
	///<summary>Check whether the given curve key time(sec) for the given curve name has the expected time(sec)</summary>
	public static FInterchangeTestFunctionResult CheckCurveKeyTime(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyTime) { return default; }
	///<summary>Check whether the given curve key value for the given curve name has the expected value</summary>
	public static FInterchangeTestFunctionResult CheckCurveKeyValue(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyValue) { return default; }
	///<summary>Check whether the given curve key arrive tangent for the given curve name has the expected arrive tangent</summary>
	public static FInterchangeTestFunctionResult CheckCurveKeyArriveTangent(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangent) { return default; }
	///<summary>Check whether the given curve key arrive tangent weight for the given curve name has the expected arrive tangent weight</summary>
	public static FInterchangeTestFunctionResult CheckCurveKeyArriveTangentWeight(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangentWeight) { return default; }
	///<summary>Check whether the given curve key leave tangent for the given curve name has the expected leave tangent</summary>
	public static FInterchangeTestFunctionResult CheckCurveKeyLeaveTangent(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangent) { return default; }
	///<summary>Check whether the given curve key leave tangent weight for the given curve name has the expected leave tangent weight</summary>
	public static FInterchangeTestFunctionResult CheckCurveKeyLeaveTangentWeight(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangentWeight) { return default; }
}

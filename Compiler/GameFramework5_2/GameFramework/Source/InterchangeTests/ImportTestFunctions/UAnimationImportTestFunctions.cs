#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AnimationImportTestFunctions.h")]
public partial class UAnimationImportTestFunctions : UImportTestFunctionsBase {
// AnimationImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedAnimSequenceCount(TArray<UAnimSequence> AnimSequences,int ExpectedNumberOfImportedAnimSequences) { return default; }
	public static FInterchangeTestFunctionResult CheckAnimationLength(UAnimSequence AnimSequence,float ExpectedAnimationLength) { return default; }
	public static FInterchangeTestFunctionResult CheckAnimationFrameNumber(UAnimSequence AnimSequence,int ExpectedFrameNumber) { return default; }
	public static FInterchangeTestFunctionResult CheckCurveKeyTime(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyTime) { return default; }
	public static FInterchangeTestFunctionResult CheckCurveKeyValue(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyValue) { return default; }
	public static FInterchangeTestFunctionResult CheckCurveKeyArriveTangent(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangent) { return default; }
	public static FInterchangeTestFunctionResult CheckCurveKeyArriveTangentWeight(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangentWeight) { return default; }
	public static FInterchangeTestFunctionResult CheckCurveKeyLeaveTangent(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangent) { return default; }
	public static FInterchangeTestFunctionResult CheckCurveKeyLeaveTangentWeight(UAnimSequence AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangentWeight) { return default; }
}

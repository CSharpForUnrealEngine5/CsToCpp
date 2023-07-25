#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/AnimationImportTestFunctions.h")]
public partial class UAnimationImportTestFunctions : UImportTestFunctionsBase {
// AnimationImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedAnimSequenceCount(TArray<UObject> AnimSequences,int ExpectedNumberOfImportedAnimSequences) { return default; }
	public FInterchangeTestFunctionResult CheckAnimationLength(UObject AnimSequence,float ExpectedAnimationLength) { return default; }
	public FInterchangeTestFunctionResult CheckAnimationFrameNumber(UObject AnimSequence,int ExpectedFrameNumber) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyTime(UObject AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyTime) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyValue(UObject AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyValue) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyArriveTangent(UObject AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangent) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyArriveTangentWeight(UObject AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyArriveTangentWeight) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyLeaveTangent(UObject AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangent) { return default; }
	public FInterchangeTestFunctionResult CheckCurveKeyLeaveTangentWeight(UObject AnimSequence,string CurveName,int KeyIndex,float ExpectedCurveKeyLeaveTangentWeight) { return default; }
}

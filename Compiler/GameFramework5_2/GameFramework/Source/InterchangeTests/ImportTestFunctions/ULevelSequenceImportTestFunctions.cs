#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelSequenceImportTestFunctions.h")]
public partial class ULevelSequenceImportTestFunctions : UImportTestFunctionsBase {
// LevelSequenceImportTestFunctions
	public FInterchangeTestFunctionResult CheckLevelSequenceCount(TArray<UObject> LevelSequences,int ExpectedNumberOfLevelSequences) { return default; }
	public FInterchangeTestFunctionResult CheckSequenceLength(UObject LevelSequence,float ExpectedLevelSequenceLength) { return default; }
	public FInterchangeTestFunctionResult CheckSectionCount(UObject LevelSequence,int ExpectedNumberOfSections) { return default; }
	public FInterchangeTestFunctionResult CheckSectionInterpolationMode(UObject LevelSequence,int SectionIndex,ERichCurveInterpMode ExpectedInterpolationMode) { return default; }
}

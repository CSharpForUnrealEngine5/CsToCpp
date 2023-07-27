#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelSequenceImportTestFunctions.h")]
public partial class ULevelSequenceImportTestFunctions : UImportTestFunctionsBase {
// LevelSequenceImportTestFunctions
	public static FInterchangeTestFunctionResult CheckLevelSequenceCount(TArray<ULevelSequence> LevelSequences,int ExpectedNumberOfLevelSequences) { return default; }
	public static FInterchangeTestFunctionResult CheckSequenceLength(ULevelSequence LevelSequence,float ExpectedLevelSequenceLength) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionCount(ULevelSequence LevelSequence,int ExpectedNumberOfSections) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionInterpolationMode(ULevelSequence LevelSequence,int SectionIndex,ERichCurveInterpMode ExpectedInterpolationMode) { return default; }
}

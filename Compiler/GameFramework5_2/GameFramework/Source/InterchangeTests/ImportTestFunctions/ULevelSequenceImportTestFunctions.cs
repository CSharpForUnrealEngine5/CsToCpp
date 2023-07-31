#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/LevelSequenceImportTestFunctions.h")]
public partial class ULevelSequenceImportTestFunctions : UImportTestFunctionsBase {
	///<summary>Check whether the expected number of level sequences are imported</summary>
	public static FInterchangeTestFunctionResult CheckLevelSequenceCount(TArray<ULevelSequence> LevelSequences,int ExpectedNumberOfLevelSequences) { return default; }
	///<summary>Check whether the level sequence length (second) is as expected</summary>
	public static FInterchangeTestFunctionResult CheckSequenceLength(ULevelSequence LevelSequence,float ExpectedLevelSequenceLength) { return default; }
	///<summary>Check whether the imported level sequence has the expected number of sections</summary>
	public static FInterchangeTestFunctionResult CheckSectionCount(ULevelSequence LevelSequence,int ExpectedNumberOfSections) { return default; }
	///<summary>Check whether the imported level sequence has the expected interpolation mode for the given section</summary>
	public static FInterchangeTestFunctionResult CheckSectionInterpolationMode(ULevelSequence LevelSequence,int SectionIndex,ERichCurveInterpMode ExpectedInterpolationMode) { return default; }
}

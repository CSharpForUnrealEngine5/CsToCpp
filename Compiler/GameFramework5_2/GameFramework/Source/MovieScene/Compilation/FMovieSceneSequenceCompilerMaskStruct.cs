#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Flag struct necessary while flag enums are not supported on UPROPERTY</summary>
[CppInclude("Compilation/MovieSceneCompiledDataManager.h")]
public partial struct FMovieSceneSequenceCompilerMaskStruct {
	public bool bHierarchy;
	public bool bEvaluationTemplate;
	public bool bEvaluationTemplateField;
	public bool bEntityComponentField;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneSectionParameters.h")]
///<summary>Flag structure that can be applied to any sub-section allowing control over various</summary>
public enum EMovieSceneSubSectionFlags {
	None=0,
	OverrideKeepState=-1,
	OverrideRestoreState=-1,
	IgnoreHierarchicalBias=-1,
	BlendHierarchicalBias=-1,
	AnyRestoreStateOverride=-1,
}

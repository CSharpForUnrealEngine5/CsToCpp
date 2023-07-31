#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Per Element Translation in the Pattern Tool</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool_TranslationSettings : UInteractiveToolPropertySet {
	///<summary>If true, Translation is linearly interpolated between StartTranslation and Translation values</summary>
	public bool bInterpolate;
	///<summary>If true, Translation at each Pattern Element is offset by a uniformly chosen random value in the range of [-TranslationJitterRange, TranslationJitterRange]</summary>
	public bool bJitter;
	///<summary>Translation applied to all Pattern Elements, or to first Pattern Element for Interpolated translation</summary>
	public FVector StartTranslation;
	///<summary>Translation applied to last Pattern Element for Interpolated translation</summary>
	public FVector EndTranslation;
	///<summary>Upper bound of the range which is sampled to randomly translate each Pattern Element if Jitter is true</summary>
	public FVector Jitter;
}

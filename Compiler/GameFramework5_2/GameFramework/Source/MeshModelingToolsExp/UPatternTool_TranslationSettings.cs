#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>Settings for Per Element Translation in the Pattern Tool</summary>
public partial class UPatternTool_TranslationSettings : UInteractiveToolPropertySet {
// PatternTool_TranslationSettings
	public bool bInterpolate;
	public bool bJitter;
	public FVector StartTranslation;
	public FVector EndTranslation;
	public FVector Jitter;
}

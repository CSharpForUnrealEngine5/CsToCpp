#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>Settings for Per Element Scale in the Pattern Tool</summary>
public partial class UPatternTool_ScaleSettings : UInteractiveToolPropertySet {
// PatternTool_ScaleSettings
	public bool bProportional;
	public bool bInterpolate;
	public bool bJitter;
	public FVector StartScale;
	public FVector EndScale;
	public FVector Jitter;
}

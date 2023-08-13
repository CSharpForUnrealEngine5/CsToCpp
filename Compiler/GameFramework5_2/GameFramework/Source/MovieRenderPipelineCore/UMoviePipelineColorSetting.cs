namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineColorSetting.h")]
public partial class UMoviePipelineColorSetting : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
	///<summary>OCIO config to be passed to OCIO View Extension. If this is enabled the Tone Curve will be disabled.</summary>
	public FOpenColorIODisplayConfiguration OCIOConfiguration;
	///<summary>If true the Filmic Tone Curve will not be applied. Disabling this will allow you to export linear data for EXRs. Force Disabled if Open Color IO is enabled.</summary>
	public bool bDisableToneCurve;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/CompositionGraphCaptureProtocol.h")]
///<summary>Used by UCompositionGraphCaptureSettings. Matches gamut order in EDisplayColorGamut</summary>
public enum EHDRCaptureGamut {
	HCGM_Rec709=0,
	HCGM_P3DCI=1,
	HCGM_Rec2020=2,
	HCGM_ACES=3,
	HCGM_ACEScg=4,
	HCGM_Linear=5,
	HCGM_MAX=6,
}

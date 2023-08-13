namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithCineCameraComponentTemplate.h")]
public partial struct FDatasmithPostProcessSettingsTemplate {
	public bool bOverride_WhiteTemp;
	public bool bOverride_ColorSaturation;
	public bool bOverride_VignetteIntensity;
	public bool bOverride_AutoExposureMethod;
	public bool bOverride_CameraISO;
	public bool bOverride_CameraShutterSpeed;
	public bool bOverride_DepthOfFieldFstop;
	public float WhiteTemp;
	public float VignetteIntensity;
	public FVector4 ColorSaturation;
	public EAutoExposureMethod AutoExposureMethod;
	public float CameraISO;
	public float CameraShutterSpeed;
	public float DepthOfFieldFstop;
}

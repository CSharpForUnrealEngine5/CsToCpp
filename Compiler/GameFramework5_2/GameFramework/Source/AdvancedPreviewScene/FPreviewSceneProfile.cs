#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetViewerSettings.h")]
///<summary>Preview scene profile settings structure.</summary>
public partial struct FPreviewSceneProfile {
// PreviewSceneProfile
	public string ProfileName;
	public bool bSharedProfile;
	public bool bUseSkyLighting;
	public float DirectionalLightIntensity;
	public FLinearColor DirectionalLightColor;
	public float SkyLightIntensity;
	public bool bRotateLightingRig;
	public bool bShowEnvironment;
	public bool bShowFloor;
	public FLinearColor EnvironmentColor;
	public float EnvironmentIntensity;
	public TSoftObjectPtr<UTextureCube> EnvironmentCubeMap;
	public string EnvironmentCubeMapPath;
	public bool bPostProcessingEnabled;
	public FPostProcessSettings PostProcessingSettings;
	public float LightingRigRotation;
	public float RotationSpeed;
	public FRotator DirectionalLightRotation;
}

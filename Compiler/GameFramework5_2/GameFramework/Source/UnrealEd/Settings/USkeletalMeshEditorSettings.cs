#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the skeletal mesh editor.</summary>
[CppInclude("Settings/SkeletalMeshEditorSettings.h")]
public partial class USkeletalMeshEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AnimPreviewFloorColor</summary>
	public FColor AnimPreviewFloorColor;
	///<summary>AnimPreviewSkyColor</summary>
	public FColor AnimPreviewSkyColor;
	///<summary>AnimPreviewSkyBrightness</summary>
	public float AnimPreviewSkyBrightness;
	///<summary>AnimPreviewLightBrightness</summary>
	public float AnimPreviewLightBrightness;
	///<summary>AnimPreviewLightingDirection</summary>
	public FRotator AnimPreviewLightingDirection;
	///<summary>AnimPreviewDirectionalColor</summary>
	public FColor AnimPreviewDirectionalColor;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPSettings.h")]
public partial class UVPSettings : UObject {
// VPSettings
	public TArray<float> FocalLengthPresets;
	public TArray<float> AperturePresets;
	public TArray<float> DefaultShutterSpeedPresets;
	public TArray<float> DefaultISOPresets;
	public static UVPSettings GetVPSettings() { return default; }
	public bool bShowRoleInEditor;
	public string DirectorName;
	public string ShowName;
	public FGameplayTagContainer Roles;
}

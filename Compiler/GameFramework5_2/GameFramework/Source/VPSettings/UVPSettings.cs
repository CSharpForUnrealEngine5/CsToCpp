#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPSettings.h")]
public partial class UVPSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Default Kit of Focal Lengths for Virtual Camera</summary>
	public TArray<float> FocalLengthPresets;
	///<summary>Default Apertures for for Virtual Camera</summary>
	public TArray<float> AperturePresets;
	///<summary>Default Shutter Speeds (1/s) for Virtual Camera</summary>
	public TArray<float> DefaultShutterSpeedPresets;
	///<summary>Default ISOs for Virtual Camera</summary>
	public TArray<float> DefaultISOPresets;
	///<summary>GetVPSettings</summary>
	public static UVPSettings GetVPSettings() { return default; }
	///<summary>When enabled, the virtual production role(s) will be displayed in the main editor UI.</summary>
	public bool bShowRoleInEditor;
	///<summary>DirectorName</summary>
	public string DirectorName;
	///<summary>ShowName</summary>
	public string ShowName;
	///<summary>The machine role(s) in a virtual production context.</summary>
	public FGameplayTagContainer Roles;
}

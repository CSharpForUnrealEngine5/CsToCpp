#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeSettings.h")]
public partial class UXRCreativeSettings : UDeveloperSettingsBackedByCVars {
	///<summary>bUseImperial</summary>
	public bool bUseImperial;
	///<summary>FloatArray</summary>
	public TArray<float> FloatArray;
	///<summary>SubsystemHelpersClass</summary>
	public TSoftObjectPtr<UClass> SubsystemHelpersClass;
	///<summary>GetXRCreativeSettings</summary>
	public static UXRCreativeSettings GetXRCreativeSettings() { return default; }
}

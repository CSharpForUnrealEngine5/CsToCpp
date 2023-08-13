namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeSettings.h")]
public partial class UXRCreativeSettings : UDeveloperSettingsBackedByCVars {
	public static UClass StaticClass() {return default;}
	///<summary>bUseImperial</summary>
	public bool bUseImperial;
	///<summary>FloatArray</summary>
	public TArray<float> FloatArray;
	///<summary>SubsystemHelpersClass</summary>
	public TSoftObjectPtr<UClass> SubsystemHelpersClass;
	///<summary>GetXRCreativeSettings</summary>
	public static UXRCreativeSettings GetXRCreativeSettings() { return default; }
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononOcclusionSourceSettings.h")]
public partial class UPhononOcclusionSourceSettings : UOcclusionPluginSourceSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>DirectOcclusionMode</summary>
	public EIplDirectOcclusionMode DirectOcclusionMode;
	///<summary>DirectOcclusionMethod</summary>
	public EIplDirectOcclusionMethod DirectOcclusionMethod;
	///<summary>DirectOcclusionSourceRadius</summary>
	public float DirectOcclusionSourceRadius;
	///<summary>DirectAttenuation</summary>
	public bool DirectAttenuation;
	///<summary>AirAbsorption</summary>
	public bool AirAbsorption;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononOcclusionSourceSettings.h")]
public partial class UPhononOcclusionSourceSettings : UOcclusionPluginSourceSettingsBase {
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

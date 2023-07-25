#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononOcclusionSourceSettings.h")]
public partial class UPhononOcclusionSourceSettings : UOcclusionPluginSourceSettingsBase {
// PhononOcclusionSourceSettings
	public EIplDirectOcclusionMode DirectOcclusionMode;
	public EIplDirectOcclusionMethod DirectOcclusionMethod;
	public float DirectOcclusionSourceRadius;
	public bool DirectAttenuation;
	public bool AirAbsorption;
}

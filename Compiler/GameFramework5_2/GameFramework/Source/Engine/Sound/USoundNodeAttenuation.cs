#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeAttenuation.h")]
///<summary>Defines how a sound's volume changes based on distance to the listener</summary>
public partial class USoundNodeAttenuation : USoundNode {
// SoundNodeAttenuation
	public USoundAttenuation AttenuationSettings;
	public FSoundAttenuationSettings AttenuationOverrides;
	public bool bOverrideAttenuation;
}

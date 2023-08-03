#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how a sound&#39;s volume changes based on distance to the listener</summary>
[CppInclude("Sound/SoundNodeAttenuation.h")]
public partial class USoundNodeAttenuation : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>AttenuationSettings</summary>
	public USoundAttenuation AttenuationSettings;
	///<summary>AttenuationOverrides</summary>
	public FSoundAttenuationSettings AttenuationOverrides;
	///<summary>bOverrideAttenuation</summary>
	public bool bOverrideAttenuation;
}

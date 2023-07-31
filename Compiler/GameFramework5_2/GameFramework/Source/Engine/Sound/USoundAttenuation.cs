#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how a sound changes volume with distance to the listener</summary>
[CppInclude("Sound/SoundAttenuation.h")]
public partial class USoundAttenuation : UObject {
	///<summary>Attenuation</summary>
	public FSoundAttenuationSettings Attenuation;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how a sound changes volume with distance to the listener</summary>
[CppInclude("Sound/SoundAttenuation.h")]
public partial class USoundAttenuation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Attenuation</summary>
	public FSoundAttenuationSettings Attenuation;
}

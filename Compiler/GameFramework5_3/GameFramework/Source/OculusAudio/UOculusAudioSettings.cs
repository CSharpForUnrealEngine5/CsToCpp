namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusAudioSettings.h")]
public partial class UOculusAudioSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OutputSubmix</summary>
	public FSoftObjectPath OutputSubmix;
	///<summary>ReverbWetLevel</summary>
	public float ReverbWetLevel;
	///<summary>EarlyReflections</summary>
	public bool EarlyReflections;
	///<summary>LateReverberation</summary>
	public bool LateReverberation;
	///<summary>PropagationQuality</summary>
	public float PropagationQuality;
	///<summary>Width</summary>
	public float Width;
	///<summary>Height</summary>
	public float Height;
	///<summary>Depth</summary>
	public float Depth;
	///<summary>ReflectionCoefRight</summary>
	public float ReflectionCoefRight;
	///<summary>ReflectionCoefLeft</summary>
	public float ReflectionCoefLeft;
	///<summary>ReflectionCoefUp</summary>
	public float ReflectionCoefUp;
	///<summary>ReflectionCoefDown</summary>
	public float ReflectionCoefDown;
	///<summary>ReflectionCoefBack</summary>
	public float ReflectionCoefBack;
	///<summary>ReflectionCoefFront</summary>
	public float ReflectionCoefFront;
}

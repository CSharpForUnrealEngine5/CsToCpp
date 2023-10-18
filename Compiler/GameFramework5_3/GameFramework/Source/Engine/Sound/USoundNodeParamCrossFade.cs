namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Crossfades between different sounds based on a parameter</summary>
[CppInclude("Sound/SoundNodeParamCrossFade.h")]
public partial class USoundNodeParamCrossFade : USoundNodeDistanceCrossFade {
	public static UClass StaticClass() {return default;}
	///<summary>Parameter controlling cross fades.</summary>
	public FName ParamName;
}

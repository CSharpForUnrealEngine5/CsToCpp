#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Crossfades between different sounds based on a parameter</summary>
[CppInclude("Sound/SoundNodeParamCrossFade.h")]
public partial class USoundNodeParamCrossFade : USoundNodeDistanceCrossFade {
	public static UClass StaticClass() {return default;}
	///<summary>Parameter controlling cross fades.</summary>
	public string ParamName;
}

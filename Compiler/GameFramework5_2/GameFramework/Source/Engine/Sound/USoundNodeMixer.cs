#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how concurrent sounds are mixed together</summary>
[CppInclude("Sound/SoundNodeMixer.h")]
public partial class USoundNodeMixer : USoundNode {
	///<summary>A volume for each input.  Automatically sized.</summary>
	public TArray<float> InputVolume;
}

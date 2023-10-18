namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how concurrent sounds are mixed together</summary>
[CppInclude("Sound/SoundNodeMixer.h")]
public partial class USoundNodeMixer : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>A volume for each input.  Automatically sized.</summary>
	public TArray<float> InputVolume;
}

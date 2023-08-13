namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remaps the SoundClass of SoundWaves underneath this</summary>
[CppInclude("Sound/SoundNodeSoundClass.h")]
public partial class USoundNodeSoundClass : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>SoundClassOverride</summary>
	public USoundClass SoundClassOverride;
}

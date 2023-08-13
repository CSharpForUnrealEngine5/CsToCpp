namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how a sound loops; either indefinitely, or for a set number of times.</summary>
[CppInclude("Sound/SoundNodeLooping.h")]
public partial class USoundNodeLooping : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>The amount of times to loop</summary>
	public int LoopCount;
	///<summary>If enabled, the node will continue to loop indefinitely regardless of the Loop Count value.</summary>
	public bool bLoopIndefinitely;
}

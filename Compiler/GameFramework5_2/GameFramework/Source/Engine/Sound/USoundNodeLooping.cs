#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeLooping.h")]
///<summary>Defines how a sound loops; either indefinitely, or for a set number of times.</summary>
public partial class USoundNodeLooping : USoundNode {
// SoundNodeLooping
	public int LoopCount;
	public bool bLoopIndefinitely;
}

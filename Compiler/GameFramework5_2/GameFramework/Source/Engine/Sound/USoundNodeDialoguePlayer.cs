#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeDialoguePlayer.h")]
///<summary>Sound node that contains a reference to the dialogue table to pull from and be played</summary>
public partial class USoundNodeDialoguePlayer : USoundNode {
// SoundNodeDialoguePlayer
	public FDialogueWaveParameter DialogueWaveParameter;
	public bool bLooping;
}

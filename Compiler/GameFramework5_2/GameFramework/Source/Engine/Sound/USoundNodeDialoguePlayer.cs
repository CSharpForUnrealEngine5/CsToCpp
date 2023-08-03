#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound node that contains a reference to the dialogue table to pull from and be played</summary>
[CppInclude("Sound/SoundNodeDialoguePlayer.h")]
public partial class USoundNodeDialoguePlayer : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>DialogueWaveParameter</summary>
	public FDialogueWaveParameter DialogueWaveParameter;
	///<summary>Whether the dialogue line should be played looping</summary>
	public bool bLooping;
}

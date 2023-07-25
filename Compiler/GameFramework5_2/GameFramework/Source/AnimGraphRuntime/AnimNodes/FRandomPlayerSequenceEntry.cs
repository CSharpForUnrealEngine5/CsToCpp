#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_RandomPlayer.h")]
///<summary>The random player node holds a list of sequences and parameter ranges which will be played continuously</summary>
public partial struct FRandomPlayerSequenceEntry {
// RandomPlayerSequenceEntry
	public UAnimSequenceBase Sequence;
	public float ChanceToPlay;
	public int MinLoopCount;
	public int MaxLoopCount;
	public float MinPlayRate;
	public float MaxPlayRate;
	public FAlphaBlend BlendIn;
}

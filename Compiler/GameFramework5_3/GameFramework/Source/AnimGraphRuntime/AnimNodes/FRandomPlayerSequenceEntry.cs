namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The random player node holds a list of sequences and parameter ranges which will be played continuously</summary>
[CppInclude("AnimNodes/AnimNode_RandomPlayer.h")]
public partial struct FRandomPlayerSequenceEntry {
	public UAnimSequenceBase Sequence;
	public float ChanceToPlay;
	public int MinLoopCount;
	public int MaxLoopCount;
	public float MinPlayRate;
	public float MaxPlayRate;
	public FAlphaBlend BlendIn;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_RandomPlayer.h")]
public partial struct FAnimNode_RandomPlayer {
// AnimNode_RandomPlayer
	public TArray<FRandomPlayerSequenceEntry> Entries;
	public bool bIgnoreForRelevancyTest;
	public float BlendWeight;
	public bool bShuffleMode;
}

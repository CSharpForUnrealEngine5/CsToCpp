#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeRandom.h")]
///<summary>Selects sounds from a random set</summary>
public partial class USoundNodeRandom : USoundNode {
// SoundNodeRandom
	public TArray<float> Weights;
	public TArray<bool> HasBeenUsed;
	public int NumRandomUsed;
	public int PreselectAtLevelLoad;
	public bool bShouldExcludeFromBranchCulling;
	public bool bSoundCueExcludedFromBranchCulling;
	public bool bRandomizeWithoutReplacement;
	public TArray<int> PIEHiddenNodes;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects sounds from a random set</summary>
[CppInclude("Sound/SoundNodeRandom.h")]
public partial class USoundNodeRandom : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>Weights</summary>
	public TArray<float> Weights;
	///<summary>Internal state of which sounds have been played.  This is only used at runtime</summary>
	public TArray<bool> HasBeenUsed;
	///<summary>Counter var so we don&#39;t have to count all of the used sounds each time we choose a sound *</summary>
	public int NumRandomUsed;
	///<summary>If greater than 0, then upon each level load such a number of inputs will be randomly selected</summary>
	public int PreselectAtLevelLoad;
	///<summary>If set to true, this random node will not be culled on load for platforms with a maximum amount of preloaded random branches</summary>
	public bool bShouldExcludeFromBranchCulling;
	///<summary>Exclusion for branch culling set by the sound cue.</summary>
	public bool bSoundCueExcludedFromBranchCulling;
	///<summary>Determines whether or not this SoundNodeRandom should randomize with or without</summary>
	public bool bRandomizeWithoutReplacement;
	///<summary>Editor only list of nodes hidden to duplicate behavior of PreselectAtLevelLoad</summary>
	public TArray<int> PIEHiddenNodes;
}

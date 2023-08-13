namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a source animation asset used by a search index.</summary>
[CppInclude("PoseSearch/PoseSearchIndex.h")]
public partial struct FPoseSearchIndexAsset {
	public ESearchIndexAssetType Type;
	public int SourceAssetIdx;
	public bool bMirrored;
	public FVector BlendParameters;
	public FFloatInterval SamplingInterval;
	public int FirstPoseIdx;
	public int NumPoses;
}

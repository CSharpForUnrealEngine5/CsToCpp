#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchIndex.h")]
///<summary>Information about a source animation asset used by a search index.</summary>
public partial struct FPoseSearchIndexAsset {
// PoseSearchIndexAsset
	public ESearchIndexAssetType Type;
	public int SourceAssetIdx;
	public bool bMirrored;
	public FVector BlendParameters;
	public FFloatInterval SamplingInterval;
	public int FirstPoseIdx;
	public int NumPoses;
}

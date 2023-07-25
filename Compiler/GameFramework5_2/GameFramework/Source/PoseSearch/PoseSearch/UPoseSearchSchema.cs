#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchSchema.h")]
///<summary>Specifies the format of a pose search index. At runtime, queries are built according to the schema for searching.</summary>
public partial class UPoseSearchSchema : UDataAsset {
// PoseSearchSchema
	public USkeleton Skeleton;
	public int SampleRate;
	public TArray<UPoseSearchFeatureChannel> Channels;
	public UMirrorDataTable MirrorDataTable;
	public EPoseSearchDataPreprocessor DataPreprocessor;
	public int SchemaCardinality;
	public TArray<FBoneReference> BoneReferences;
	public TArray<ushort> BoneIndicesWithParents;
	public float ContinuingPoseCostBias;
	public float BaseCostBias;
	public float MirrorMismatchCostBias;
	public TArray<FPoseSearchSchemaColorPreset> ColorPresets;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies the format of a pose search index. At runtime, queries are built according to the schema for searching.</summary>
[CppInclude("PoseSearch/PoseSearchSchema.h")]
public partial class UPoseSearchSchema : UDataAsset {
	///<summary>@todo: used only for indexing: cache it somewhere else</summary>
	public USkeleton Skeleton;
	///<summary>SampleRate</summary>
	public int SampleRate;
	///<summary>Channels</summary>
	public TArray<UPoseSearchFeatureChannel> Channels;
	///<summary>If set, this schema will support mirroring pose search databases</summary>
	public UMirrorDataTable MirrorDataTable;
	///<summary>DataPreprocessor</summary>
	public EPoseSearchDataPreprocessor DataPreprocessor;
	///<summary>SchemaCardinality</summary>
	public int SchemaCardinality;
	///<summary>@todo: used only for indexing: cache it somewhere else</summary>
	public TArray<FBoneReference> BoneReferences;
	///<summary>BoneIndicesWithParents</summary>
	public TArray<ushort> BoneIndicesWithParents;
	///<summary>cost added to the continuing pose from databases that uses this schema</summary>
	public float ContinuingPoseCostBias;
	///<summary>base cost added to all poses from databases that uses this schema. it can be overridden by UAnimNotifyState_PoseSearchModifyCost</summary>
	public float BaseCostBias;
	///<summary>If there&#39;s a mirroring mismatch between the currently playing asset and a search candidate, this cost will be</summary>
	public float MirrorMismatchCostBias;
	///<summary>ColorPresets</summary>
	public TArray<FPoseSearchSchemaColorPreset> ColorPresets;
}

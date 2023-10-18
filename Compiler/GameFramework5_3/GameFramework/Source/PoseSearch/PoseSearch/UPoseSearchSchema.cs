namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies the format of a pose search index. At runtime, queries are built according to the schema for searching.</summary>
[CppInclude("PoseSearch/PoseSearchSchema.h")]
public partial class UPoseSearchSchema : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Skeleton Reference for Motion Matching Database assets. Must be set to a compatible skeleton to the animation data in the database.</summary>
	public USkeleton Skeleton;
	///<summary>The update rate at which we sample the animation data in the database. The higher the SampleRate the more refined your searches will be, but the more memory will be required</summary>
	public int SampleRate;
	///<summary>Channels itemize the cost breakdown of the config in simpler parts such as position or velocity of a bones, or phase of limbs. The total cost of a query against an indexed database pose will be the sum of the combined channel costs</summary>
	public TArray<UPoseSearchFeatureChannel> Channels;
	///<summary>FinalizedChannels gets populated with UPoseSearchFeatureChannel(s) from Channels and additional injected ones during the Finalize.</summary>
	public TArray<UPoseSearchFeatureChannel> FinalizedChannels;
	///<summary>Setting up and assigning a mirror data table will allow all your assets in your database to access the mirrored version of the data. This is required for mirroring to work with Motion Matching.</summary>
	public UMirrorDataTable MirrorDataTable;
	///<summary>Type of operation performed to the full pose features dataset</summary>
	public EPoseSearchDataPreprocessor DataPreprocessor;
	///<summary>SchemaCardinality</summary>
	public int SchemaCardinality;
	///<summary>BoneReferences</summary>
	public TArray<FBoneReference> BoneReferences;
	///<summary>BoneIndicesWithParents</summary>
	public TArray<ushort> BoneIndicesWithParents;
	///<summary>Cost added to the continuing pose from databases that uses this config. This allows users to apply a cost bias (positive or negative) to the continuing pose.</summary>
	public float ContinuingPoseCostBias;
	///<summary>Base Cost added or removed to all poses from databases that use this config. It can be overridden by Anim Notify: Pose Search Modify Cost at the frame level of animation data.</summary>
	public float BaseCostBias;
	///<summary>Cost added to all looping animation assets in a database that uses this config. This allows users to make it more or less likely to pick the looping animation segments.</summary>
	public float LoopingCostBias;
	///<summary>How many times the animation assets of the database using this schema will be indexed.</summary>
	public int NumberOfPermutations;
	///<summary>Delta time between every permutation indexing.</summary>
	public int PermutationsSampleRate;
	///<summary>Starting offset of the &quot;PermutationTime&quot; from the &quot;SamplingTime&quot; of the first permutation.</summary>
	public float PermutationsTimeOffset;
	///<summary>if true a padding channel will be added to make sure the data is 16 bytes (aligned) and padded, to facilitate performance improvements at cost of eventual additional memory</summary>
	public bool bAddDataPadding;
	///<summary>If bInjectAdditionalDebugChannels is true, channels will be asked to inject additional channels into this schema.</summary>
	public bool bInjectAdditionalDebugChannels;
}

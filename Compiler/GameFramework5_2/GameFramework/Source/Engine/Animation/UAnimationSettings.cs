namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default animation settings.</summary>
[CppInclude("Animation/AnimationSettings.h")]
public partial class UAnimationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Compression version for recompress commandlet, bump this to trigger full recompressed, otherwise only new imported animations will be recompressed</summary>
	public int CompressCommandletVersion;
	///<summary>List of bone names to treat with higher precision, in addition to any bones with sockets</summary>
	public TArray<string> KeyEndEffectorsMatchNameArray;
	///<summary>If true, this will forcibly recompress every animation, this should not be checked in enabled</summary>
	public bool ForceRecompression;
	///<summary>If true and the existing compression error is greater than Alternative Compression Threshold, then any compression technique (even one that increases the size) with a lower error will be used until it falls below the threshold</summary>
	public bool bForceBelowThreshold;
	///<summary>If true, then the animation will be first recompressed with it&#39;s current compressor if non-NULL, or with the global default compressor (specified in the engine ini)</summary>
	public bool bFirstRecompressUsingCurrentOrDefault;
	///<summary>, EditAnywhere, Category = Compression</summary>
	public bool bRaiseMaxErrorToExisting;
	///<summary>If true, recompression will log performance information</summary>
	public bool bEnablePerformanceLog;
	///<summary>If true, animation track data will be stripped from dedicated server cooked data</summary>
	public bool bStripAnimationDataOnDedicatedServer;
	///<summary>If true, pre-4.19 behavior of zero-ticking animations during skeletal mesh init</summary>
	public bool bTickAnimationOnSkeletalMeshInit;
	///<summary>Names that identify bone animation attributes representing the individual components of a timecode and a subframe along with a take name.</summary>
	public FTimecodeCustomAttributeNameSettings BoneTimecodeCustomAttributeNameSettings;
	///<summary>List of animation attribute names to import directly on their corresponding bone names. The meaning field allows to contextualize the attribute name and customize tooling for it.</summary>
	public TArray<FCustomAttributeSetting> BoneCustomAttributesNames;
	///<summary>Gets the complete list of bone animation attribute names to consider for import.</summary>
	public TArray<string> GetBoneCustomAttributeNamesToImport() { return default; }
	///<summary>List of bone names for which all animation attributes are directly imported on the bone.</summary>
	public TArray<string> BoneNamesWithCustomAttributes;
	///<summary>Animation Attribute specific blend types (by name)</summary>
	public TMap<FName,ECustomAttributeBlendType> AttributeBlendModes;
	///<summary>Default Animation Attribute blend type</summary>
	public ECustomAttributeBlendType DefaultAttributeBlendMode;
	///<summary>Names to match against when importing FBX node transform curves as attributes (can use ? and * wildcards)</summary>
	public TArray<string> TransformAttributeNames;
	///<summary>Register user defined structs as animation attributes</summary>
	public TArray<TSoftObjectPtr<UUserDefinedStruct>> UserDefinedStructAttributes;
	///<summary>Find and Replace Expressions used for mirroring</summary>
	public TArray<FMirrorFindReplaceExpression> MirrorFindReplaceExpressions;
	///<summary>Project specific default frame-rate used when (re)initializing any animation based data</summary>
	public FFrameRate DefaultFrameRate;
}

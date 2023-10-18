namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An ACL database object references several UAnimSequence instances that it contains.</summary>
[CppInclude("AnimationCompressionLibraryDatabase.h")]
public partial class UAnimationCompressionLibraryDatabase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The raw binary data for our compressed database and anim sequences. Present only in cooked builds.</summary>
	public TArray<byte> CookedCompressedBytes;
	///<summary>Stores a mapping for each anim sequence, where its compressed data lives in our compressed buffer. Each 64 bit value is split into 32 bits: (Hash &lt;&lt; 32) | Offset. Present only in cooked builds.</summary>
	public TArray<ulong> CookedAnimSequenceMappings;
	///<summary>What percentage of the key frames should remain in the anim sequences.</summary>
	public float HighestImportanceProportion;
	///<summary>What percentage of the key frames should be moved to the database. Medium importance key frames are moved second.</summary>
	public float MediumImportanceProportion;
	///<summary>What percentage of the key frames should be moved to the database. Least important key frames are moved first.</summary>
	public float LowestImportanceProportion;
	///<summary>Whether or not to strip the lowest importance tier entirely from disk. Stripping the lowest tier means that the visual fidelity of Highest and Medium are equivalent.</summary>
	public FPerPlatformBool StripLowestImportanceTier;
	///<summary>The maximum size in KiloBytes of streaming requests. Setting this to 0 will force tiers to load in a single request regardless of their size.</summary>
	public uint MaxStreamRequestSizeKB;
	///<summary>The level of quality to preview with the database when decompressing in the editor.</summary>
	public ACLVisualFidelity PreviewVisualFidelity;
	///<summary>The anim sequences contained within the database. Built manually from the asset UI, content browser, or with a commandlet.</summary>
	public TArray<UAnimSequence> AnimSequences;
	///<summary>Initiate a latent database change in quality by streaming in/out as necessary.</summary>
	public static void SetVisualFidelity(UObject WorldContextObject,FLatentActionInfo LatentInfo,UAnimationCompressionLibraryDatabase DatabaseAsset,ACLVisualFidelityChangeResult Result,ACLVisualFidelity VisualFidelity/*=ACLVisualFidelity.Highest*/) {}
	///<summary>GetVisualFidelity</summary>
	public static ACLVisualFidelity GetVisualFidelity(UAnimationCompressionLibraryDatabase DatabaseAsset) { return default; }
}

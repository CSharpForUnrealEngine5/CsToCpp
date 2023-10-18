namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base codec implementation for ACL support.</summary>
[CppInclude("AnimBoneCompressionCodec_ACLBase.h")]
public partial class UAnimBoneCompressionCodec_ACLBase : UAnimBoneCompressionCodec {
	public static UClass StaticClass() {return default;}
	///<summary>The compression level to use. Higher levels will be slower to compress but yield a lower memory footprint.</summary>
	public ACLCompressionLevel CompressionLevel;
	///<summary>The default virtual vertex distance for normal bones.</summary>
	public float DefaultVirtualVertexDistance;
	///<summary>The virtual vertex distance for bones that requires extra accuracy.</summary>
	public float SafeVirtualVertexDistance;
	///<summary>The error threshold to use when optimizing and compressing the animation sequence.</summary>
	public float ErrorThreshold;
}

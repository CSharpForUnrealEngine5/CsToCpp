namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses the open source Animation Compression Library with default settings and database support.</summary>
[CppInclude("AnimBoneCompressionCodec_ACLDatabase.h")]
public partial class UAnimBoneCompressionCodec_ACLDatabase : UAnimBoneCompressionCodec_ACLBase {
	public static UClass StaticClass() {return default;}
	///<summary>The database asset that will hold the compressed animation data.</summary>
	public UAnimationCompressionLibraryDatabase DatabaseAsset;
	///<summary>The skeletal meshes used to estimate the skinning deformation during compression.</summary>
	public TArray<USkeletalMesh> OptimizationTargets;
}

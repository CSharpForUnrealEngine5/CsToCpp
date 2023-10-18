namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses the open source Animation Compression Library with default settings suitable for general purpose animations.</summary>
[CppInclude("AnimBoneCompressionCodec_ACL.h")]
public partial class UAnimBoneCompressionCodec_ACL : UAnimBoneCompressionCodec_ACLBase {
	public static UClass StaticClass() {return default;}
	///<summary>The skeletal meshes used to estimate the skinning deformation during compression.</summary>
	public TArray<USkeletalMesh> OptimizationTargets;
}

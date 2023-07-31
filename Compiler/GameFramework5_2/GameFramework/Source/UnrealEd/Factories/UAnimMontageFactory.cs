#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/AnimMontageFactory.h")]
public partial class UAnimMontageFactory : UFactory {
	///<summary>TargetSkeleton</summary>
	public USkeleton TargetSkeleton;
	///<summary>Used when creating a montage from an AnimSequence, becomes the only AnimSequence contained</summary>
	public UAnimSequence SourceAnimation;
	///<summary>The preview mesh to use with this animation</summary>
	public USkeletalMesh PreviewSkeletalMesh;
}

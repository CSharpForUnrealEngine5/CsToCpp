namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/AnimCompositeFactory.h")]
public partial class UAnimCompositeFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>TargetSkeleton</summary>
	public USkeleton TargetSkeleton;
	///<summary>Used when creating a composite from an AnimSequence, becomes the only AnimSequence contained</summary>
	public UAnimSequence SourceAnimation;
	///<summary>The preview mesh to use with this animation</summary>
	public USkeletalMesh PreviewSkeletalMesh;
}

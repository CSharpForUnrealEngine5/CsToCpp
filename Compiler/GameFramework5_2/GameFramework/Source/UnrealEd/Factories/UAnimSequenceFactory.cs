namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/AnimSequenceFactory.h")]
public partial class UAnimSequenceFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>TargetSkeleton</summary>
	public USkeleton TargetSkeleton;
	///<summary>The preview mesh to use with this animation</summary>
	public USkeletalMesh PreviewSkeletalMesh;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/BlendSpaceFactoryNew.h")]
public partial class UBlendSpaceFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>Target skeleton for the created blendspace</summary>
	public USkeleton TargetSkeleton;
	///<summary>The preview mesh to use for the created blendspace</summary>
	public USkeletalMesh PreviewSkeletalMesh;
}

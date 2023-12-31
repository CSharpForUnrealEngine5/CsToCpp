namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkinnedAsset.h")]
public partial class USkinnedAsset : UStreamableRenderAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Find a socket object in this SkeletalMesh by name.</summary>
	public virtual USkeletalMeshSocket FindSocket(FName InSocketName) { return default; }
	///<summary>Find a socket object and associated info in this SkeletalMesh by name.</summary>
	public virtual USkeletalMeshSocket FindSocketInfo(FName InSocketName,FTransform OutTransform,int OutBoneIndex,int OutIndex) { return default; }
}

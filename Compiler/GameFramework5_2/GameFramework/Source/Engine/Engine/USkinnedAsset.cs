#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkinnedAsset.h")]
public partial class USkinnedAsset : UStreamableRenderAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Find a socket object in this SkeletalMesh by name.</summary>
	public  USkeletalMeshSocket FindSocket(string InSocketName) { return default; }
	///<summary>Find a socket object and associated info in this SkeletalMesh by name.</summary>
	public  USkeletalMeshSocket FindSocketInfo(string InSocketName,FTransform OutTransform,int OutBoneIndex,int OutIndex) { return default; }
}

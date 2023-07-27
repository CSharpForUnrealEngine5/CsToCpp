#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargetBatchOperation.h")]
///<summary>/ Encapsulate ability to batch duplicate and retarget a set of animation assets</summary>
public partial class UIKRetargetBatchOperation : UObject {
// IKRetargetBatchOperation
	public static TArray<FAssetData> DuplicateAndRetarget(TArray<FAssetData> AssetsToRetarget,USkeletalMesh SourceMesh,USkeletalMesh TargetMesh,UIKRetargeter IKRetargetAsset,string Search/*=""*/,string Replace/*=""*/,string Prefix/*=""*/,string Suffix/*=""*/,bool bRemapReferencedAssets/*=true*/) { return default; }
}

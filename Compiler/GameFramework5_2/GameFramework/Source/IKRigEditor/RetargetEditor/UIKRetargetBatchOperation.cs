#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>/ Encapsulate ability to batch duplicate and retarget a set of animation assets</summary>
[CppInclude("RetargetEditor/IKRetargetBatchOperation.h")]
public partial class UIKRetargetBatchOperation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Convenience function to run a batch animation retarget from Blueprint / Python. This function will duplicate a list of</summary>
	public static TArray<FAssetData> DuplicateAndRetarget(TArray<FAssetData> AssetsToRetarget,USkeletalMesh SourceMesh,USkeletalMesh TargetMesh,UIKRetargeter IKRetargetAsset,string Search/*=""*/,string Replace/*=""*/,string Prefix/*=""*/,string Suffix/*=""*/,bool bRemapReferencedAssets/*=true*/) { return default; }
}

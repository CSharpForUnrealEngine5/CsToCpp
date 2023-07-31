#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/PoseAssetFactory.h")]
public partial class UPoseAssetFactory : UFactory {
	///<summary>Used when creating a composite from an AnimSequence, becomes the only AnimSequence contained</summary>
	public UAnimSequence SourceAnimation;
	///<summary>Optional. If specified the poses will be named according to this array.</summary>
	public TArray<string> PoseNames;
	///<summary>Only used for AnimationEditorUtils::ExecuteNewAnimAsset template. Do not use directly.</summary>
	public USkeleton TargetSkeleton;
	///<summary>PreviewSkeletalMesh</summary>
	public USkeletalMesh PreviewSkeletalMesh;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
public partial struct FContextualAnimActorPreviewData {
	public string Role;
	public EContextualAnimActorPreviewType Type;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public TSoftObjectPtr<UClass> PreviewAnimInstance;
	public TSoftObjectPtr<UStaticMesh> PreviewStaticMesh;
	public TSoftObjectPtr<UClass> PreviewActorClass;
}

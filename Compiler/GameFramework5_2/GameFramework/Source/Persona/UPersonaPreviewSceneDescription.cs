#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PersonaPreviewSceneDescription.h")]
public partial class UPersonaPreviewSceneDescription : UObject {
// PersonaPreviewSceneDescription
	public UClass PreviewController;
	public UPersonaPreviewSceneController PreviewControllerInstance;
	public TArray<UPersonaPreviewSceneController> PreviewControllerInstances;
	public TSoftObjectPtr<USkeletalMesh> PreviewMesh;
	public TSoftObjectPtr<UAnimBlueprint> PreviewAnimationBlueprint;
	public EPreviewAnimationBlueprintApplicationMethod ApplicationMethod;
	public string LinkedAnimGraphTag;
	public TSoftObjectPtr<UDataAsset> AdditionalMeshes;
	public UPreviewMeshCollection DefaultAdditionalMeshes;
}

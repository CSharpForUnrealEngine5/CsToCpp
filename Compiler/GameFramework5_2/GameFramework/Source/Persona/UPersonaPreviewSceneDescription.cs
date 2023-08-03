#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PersonaPreviewSceneDescription.h")]
public partial class UPersonaPreviewSceneDescription : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The method by which the preview is animated</summary>
	public UClass PreviewController;
	///<summary>PreviewControllerInstance</summary>
	public UPersonaPreviewSceneController PreviewControllerInstance;
	///<summary>PreviewControllerInstances</summary>
	public TArray<UPersonaPreviewSceneController> PreviewControllerInstances;
	///<summary>The preview mesh to use</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewMesh;
	///<summary>The preview anim blueprint to use</summary>
	public TSoftObjectPtr<UAnimBlueprint> PreviewAnimationBlueprint;
	///<summary>The method by which a preview animation blueprint is applied, either as an overlay layer, or as a linked instance</summary>
	public EPreviewAnimationBlueprintApplicationMethod ApplicationMethod;
	///<summary>The tag to use when applying a preview animation blueprint via LinkAnimGraphByTag</summary>
	public string LinkedAnimGraphTag;
	///<summary>AdditionalMeshes</summary>
	public TSoftObjectPtr<UDataAsset> AdditionalMeshes;
	///<summary>DefaultAdditionalMeshes</summary>
	public UPreviewMeshCollection DefaultAdditionalMeshes;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UChaosClothPreviewSceneDescription is a description of the Preview scene contents, intended to be editable in an FAdvancedPreviewSettingsWidget</summary>
[CppInclude("ChaosClothAsset/ClothEditorPreviewScene.h")]
public partial class UChaosClothPreviewSceneDescription : UObject {
	///<summary>Skeletal Mesh source asset</summary>
	public USkeletalMesh SkeletalMeshAsset;
	///<summary>SkeletalMeshTransform</summary>
	public FTransform SkeletalMeshTransform;
}

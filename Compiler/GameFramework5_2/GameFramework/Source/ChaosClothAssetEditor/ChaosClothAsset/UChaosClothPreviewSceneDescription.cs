namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The UChaosClothPreviewSceneDescription is a description of the Preview scene contents, intended to be editable in an FAdvancedPreviewSettingsWidget</summary>
[CppInclude("ChaosClothAsset/ClothEditorPreviewScene.h")]
public partial class UChaosClothPreviewSceneDescription : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Skeletal Mesh source asset</summary>
	public USkeletalMesh SkeletalMeshAsset;
	///<summary>SkeletalMeshTransform</summary>
	public FTransform SkeletalMeshTransform;
}

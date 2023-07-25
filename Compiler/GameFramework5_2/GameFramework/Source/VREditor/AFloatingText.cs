#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorFloatingText.h")]
///<summary>Draws 3D text in the world along with targeting line cues</summary>
public partial class AFloatingText : AActor {
// FloatingText
	public USceneComponent SceneComponent;
	public UStaticMeshComponent FirstLineComponent;
	public UStaticMeshComponent JointSphereComponent;
	public UStaticMeshComponent SecondLineComponent;
	public UTextRenderComponent TextComponent;
	public UMaterialInterface MaskedTextMaterial;
	public UMaterialInterface TranslucentTextMaterial;
	public UMaterialInterface LineMaterial;
	public UMaterialInstanceDynamic LineMaterialMID;
}

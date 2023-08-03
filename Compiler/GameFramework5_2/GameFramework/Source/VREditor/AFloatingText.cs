#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws 3D text in the world along with targeting line cues</summary>
[CppInclude("VREditorFloatingText.h")]
public partial class AFloatingText : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Scene component root of this actor</summary>
	public USceneComponent SceneComponent;
	///<summary>First line segment component.  Starts at the designation location, goes toward the line connection point.</summary>
	public UStaticMeshComponent FirstLineComponent;
	///<summary>Sphere that connects the two line segments and makes the joint look smooth and round</summary>
	public UStaticMeshComponent JointSphereComponent;
	///<summary>Second line segment component.  Starts at the connection point and goes toward the 3D text.</summary>
	public UStaticMeshComponent SecondLineComponent;
	///<summary>The 3D text we&#39;re drawing.  Positioned at the end of the second line.</summary>
	public UTextRenderComponent TextComponent;
	///<summary>Masked text material.  Used after faded in</summary>
	public UMaterialInterface MaskedTextMaterial;
	///<summary>Translucent text material.  Used during fading</summary>
	public UMaterialInterface TranslucentTextMaterial;
	///<summary>Material to use for the line meshes</summary>
	public UMaterialInterface LineMaterial;
	///<summary>Dynamic material instance for fading lines in and out</summary>
	public UMaterialInstanceDynamic LineMaterialMID;
}

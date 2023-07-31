#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DecalActor contains a DecalComponent which can be used to render material modifications on top of existing geometry.</summary>
[CppInclude("Engine/DecalActor.h")]
public partial class ADecalActor : AActor {
	///<summary>The decal component for this decal actor</summary>
	public UDecalComponent Decal;
	///<summary>Reference to the editor only arrow visualization component</summary>
	public UArrowComponent ArrowComponent;
	///<summary>Reference to the billboard component</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>formerly we used this component to draw a box, now we use the DecalComponentVisualizer</summary>
	public UBoxComponent BoxComponent_DEPRECATED;
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public  void SetDecalMaterial(UMaterialInterface NewDecalMaterial) {}
	///<summary>GetDecalMaterial</summary>
	public  UMaterialInterface GetDecalMaterial() { return default; }
	///<summary>CreateDynamicMaterialInstance</summary>
	public  UMaterialInstanceDynamic CreateDynamicMaterialInstance() { return default; }
}

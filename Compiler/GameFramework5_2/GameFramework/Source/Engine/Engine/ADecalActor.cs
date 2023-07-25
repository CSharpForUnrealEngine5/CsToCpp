#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DecalActor.h")]
///<summary>DecalActor contains a DecalComponent which can be used to render material modifications on top of existing geometry.</summary>
public partial class ADecalActor : AActor {
// DecalActor
	public UDecalComponent Decal;
	public UArrowComponent ArrowComponent;
	public UBillboardComponent SpriteComponent;
	public UBoxComponent BoxComponent_DEPRECATED;
	public void SetDecalMaterial(UObject NewDecalMaterial) {}
	public UObject GetDecalMaterial() { return default; }
	public UObject CreateDynamicMaterialInstance() { return default; }
}

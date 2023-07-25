#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PassthroughMaterialUpdateComponent.h")]
///<summary>Helper component that automatically pick the correct passthrough material to use</summary>
public partial class UPassthroughMaterialUpdateComponent : UActorComponent {
// PassthroughMaterialUpdateComponent
	public void AddAffectedComponent(UObject InComponent) {}
	public void RemoveAffectedComponent(UObject InComponent) {}
	public void SetPassthroughDebugColor(FLinearColor NewDebugColor) {}
	public EARTextureType TextureType;
	public UMaterialInterface PassthroughMaterial;
	public UMaterialInterface PassthroughMaterialExternalTexture;
	public FLinearColor PassthroughDebugColor;
	public TArray<UPrimitiveComponent> AffectedComponents;
	public TArray<UPrimitiveComponent> PendingComponents;
}

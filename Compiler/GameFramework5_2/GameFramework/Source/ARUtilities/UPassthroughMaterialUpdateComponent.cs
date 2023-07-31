#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper component that automatically pick the correct passthrough material to use</summary>
[CppInclude("PassthroughMaterialUpdateComponent.h")]
public partial class UPassthroughMaterialUpdateComponent : UActorComponent {
	///<summary>Add a component to be affected by the passthrough rendering</summary>
	public  void AddAffectedComponent(UPrimitiveComponent InComponent) {}
	///<summary>Remove the component from passthrough rendering</summary>
	public  void RemoveAffectedComponent(UPrimitiveComponent InComponent) {}
	///<summary>Update the passthrough debug color</summary>
	public  void SetPassthroughDebugColor(FLinearColor NewDebugColor) {}
	///<summary>Which AR texture to use as the camera texture</summary>
	public EARTextureType TextureType;
	///<summary>Which material to use for a regular camera texture</summary>
	public UMaterialInterface PassthroughMaterial;
	///<summary>Which material to use for an external camera texture</summary>
	public UMaterialInterface PassthroughMaterialExternalTexture;
	///<summary>The debug color used to modulate the passthrough material.</summary>
	public FLinearColor PassthroughDebugColor;
	///<summary>AffectedComponents</summary>
	public TArray<UPrimitiveComponent> AffectedComponents;
	///<summary>PendingComponents</summary>
	public TArray<UPrimitiveComponent> PendingComponents;
}

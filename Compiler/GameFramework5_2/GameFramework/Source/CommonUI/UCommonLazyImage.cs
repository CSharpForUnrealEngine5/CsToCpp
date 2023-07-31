#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A special Image widget that can show unloaded images and takes care of the loading for you!</summary>
[CppInclude("CommonLazyImage.h")]
public partial class UCommonLazyImage : UImage {
	///<summary>Set the brush from a lazy texture asset pointer - will load the texture as needed.</summary>
	public  void SetBrushFromLazyTexture(TSoftObjectPtr<UTexture2D> LazyTexture,bool bMatchSize/*=false*/) {}
	///<summary>Set the brush from a lazy material asset pointer - will load the material as needed.</summary>
	public  void SetBrushFromLazyMaterial(TSoftObjectPtr<UMaterialInterface> LazyMaterial) {}
	///<summary>Set the brush from a string asset ref only - expects the referenced asset to be a texture or material.</summary>
	public  void SetBrushFromLazyDisplayAsset(TSoftObjectPtr<UObject> LazyObject,bool bMatchTextureSize/*=false*/) {}
	///<summary>IsLoading</summary>
	public  bool IsLoading() { return default; }
	///<summary>Establishes the name of the texture parameter on the currently applied brush material to which textures should be applied.</summary>
	public  void SetMaterialTextureParamName(string TextureParamName) {}
	///<summary>bShowLoading</summary>
	public bool bShowLoading;
	///<summary>LoadingBackgroundBrush</summary>
	public FSlateBrush LoadingBackgroundBrush;
	///<summary>If this image uses a material that a texture should be applied to, this is the name of the material param to use.</summary>
	public string MaterialTextureParamName;
	///<summary>BP_OnLoadingStateChanged</summary>
	public FOnLoadGuardStateChangedDynamic BP_OnLoadingStateChanged;
}

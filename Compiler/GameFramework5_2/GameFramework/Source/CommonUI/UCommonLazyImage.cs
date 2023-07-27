#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonLazyImage.h")]
///<summary>A special Image widget that can show unloaded images and takes care of the loading for you!</summary>
public partial class UCommonLazyImage : UImage {
// CommonLazyImage
	public  void SetBrushFromLazyTexture(TSoftObjectPtr<UTexture2D> LazyTexture,bool bMatchSize/*=false*/) {}
	public  void SetBrushFromLazyMaterial(TSoftObjectPtr<UMaterialInterface> LazyMaterial) {}
	public  void SetBrushFromLazyDisplayAsset(TSoftObjectPtr<UObject> LazyObject,bool bMatchTextureSize/*=false*/) {}
	public  bool IsLoading() { return default; }
	public  void SetMaterialTextureParamName(string TextureParamName) {}
	public bool bShowLoading;
	public FSlateBrush LoadingBackgroundBrush;
	public string MaterialTextureParamName;
	public FOnLoadGuardStateChangedDynamic BP_OnLoadingStateChanged;
}

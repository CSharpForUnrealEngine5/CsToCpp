namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFImageBlock.h")]
public partial class UUIFrameworkImageBlock : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetMaterial</summary>
	public void SetMaterial(TSoftObjectPtr<UMaterialInterface> Material) {}
	///<summary>GeResourceObject</summary>
	public TSoftObjectPtr<UObject> GeResourceObject() { return default; }
	///<summary>SetTexture</summary>
	public void SetTexture(TSoftObjectPtr<UTexture2D> Texture,bool bUseTextureSize) {}
	///<summary>SetTint</summary>
	public void SetTint(FLinearColor Tint) {}
	///<summary>GetTint</summary>
	public FLinearColor GetTint() { return default; }
	///<summary>SetDesiredSize</summary>
	public void SetDesiredSize(FVector2f DesiredSize) {}
	///<summary>GetDesiredSize</summary>
	public FVector2f GetDesiredSize() { return default; }
	///<summary>SetTiling</summary>
	public void SetTiling(ESlateBrushTileType OverflowPolicy) {}
	///<summary>GetTiling</summary>
	public ESlateBrushTileType GetTiling() { return default; }
	///<summary>OnRep_Data</summary>
	public void OnRep_Data() {}
	///<summary>Tinting applied to the image.</summary>
	public FUIFrameworkImageBlockData Data;
	///<summary>bWaitForResourceToBeLoaded</summary>
	public bool bWaitForResourceToBeLoaded;
}

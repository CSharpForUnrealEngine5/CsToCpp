namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantSet.h")]
public partial class UVariantSet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetParent</summary>
	public ULevelVariantSets GetParent() { return default; }
	///<summary>SetDisplayText</summary>
	public void SetDisplayText(FText NewDisplayText) {}
	///<summary>GetDisplayText</summary>
	public FText GetDisplayText() { return default; }
	///<summary>GetNumVariants</summary>
	public int GetNumVariants() { return default; }
	///<summary>GetVariant</summary>
	public UVariant GetVariant(int VariantIndex) { return default; }
	///<summary>GetVariantByName</summary>
	public UVariant GetVariantByName(string VariantName) { return default; }
	///<summary>Sets the thumbnail to use for this variant set. Can receive nullptr to clear it</summary>
	public void SetThumbnailFromTexture(UTexture2D NewThumbnail) {}
	///<summary>SetThumbnailFromFile</summary>
	public void SetThumbnailFromFile(string FilePath) {}
	///<summary>SetThumbnailFromCamera</summary>
	public void SetThumbnailFromCamera(UObject WorldContextObject,FTransform CameraTransform,float FOVDegrees/*=50.0f*/,float MinZ/*=50.0f*/,float Gamma/*=2.2f*/) {}
	///<summary>Sets the thumbnail from the active editor viewport. Doesn&#39;t do anything if the Editor is not available</summary>
	public void SetThumbnailFromEditorViewport() {}
	///<summary>Gets the thumbnail currently used for this variant set</summary>
	public UTexture2D GetThumbnail() { return default; }
	///<summary>The display name used to be a property. Use the non-deprecated, non-property version from now on</summary>
	public FText DisplayText_DEPRECATED;
	///<summary>bExpanded</summary>
	public bool bExpanded;
	///<summary>Variants</summary>
	public TArray<UVariant> Variants;
	///<summary>Thumbnail</summary>
	public UTexture2D Thumbnail;
}

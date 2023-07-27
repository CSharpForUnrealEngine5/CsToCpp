#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VariantSet.h")]
public partial class UVariantSet : UObject {
// VariantSet
	public  ULevelVariantSets GetParent() { return default; }
	public  void SetDisplayText(string NewDisplayText) {}
	public  string GetDisplayText() { return default; }
	public  int GetNumVariants() { return default; }
	public  UVariant GetVariant(int VariantIndex) { return default; }
	public  UVariant GetVariantByName(string VariantName) { return default; }
	public  void SetThumbnailFromTexture(UTexture2D NewThumbnail) {}
	public  void SetThumbnailFromFile(string FilePath) {}
	public  void SetThumbnailFromCamera(UObject WorldContextObject,FTransform CameraTransform,float FOVDegrees/*=50.0f*/,float MinZ/*=50.0f*/,float Gamma/*=2.2f*/) {}
	public  void SetThumbnailFromEditorViewport() {}
	public  UTexture2D GetThumbnail() { return default; }
	public string DisplayText_DEPRECATED;
	public bool bExpanded;
	public TArray<UVariant> Variants;
	public UTexture2D Thumbnail;
}

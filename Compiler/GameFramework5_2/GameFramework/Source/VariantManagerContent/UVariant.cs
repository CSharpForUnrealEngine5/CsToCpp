#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Variant.h")]
public partial class UVariant : UObject {
// Variant
	public  UVariantSet GetParent() { return default; }
	public  void SetDisplayText(string NewDisplayText) {}
	public  string GetDisplayText() { return default; }
	public  int GetNumActors() { return default; }
	public  AActor GetActor(int ActorIndex) { return default; }
	public  void SwitchOn() {}
	public  bool IsActive() { return default; }
	public  void SetThumbnailFromTexture(UTexture2D NewThumbnail) {}
	public  void SetThumbnailFromFile(string FilePath) {}
	public  void SetThumbnailFromCamera(UObject WorldContextObject,FTransform CameraTransform,float FOVDegrees/*=50.0f*/,float MinZ/*=50.0f*/,float Gamma/*=2.2f*/) {}
	public  void SetThumbnailFromEditorViewport() {}
	public  UTexture2D GetThumbnail() { return default; }
	public  TArray<UVariant> GetDependents(ULevelVariantSets LevelVariantSets,bool bOnlyEnabledDependencies) { return default; }
	public  int AddDependency(FVariantDependency Dependency) { return default; }
	public  FVariantDependency GetDependency(int Index) { return default; }
	public  void SetDependency(int Index,FVariantDependency Dependency) {}
	public  void DeleteDependency(int Index) {}
	public  int GetNumDependencies() { return default; }
	public TArray<FVariantDependency> Dependencies;
	public string DisplayText_DEPRECATED;
	public TArray<UVariantObjectBinding> ObjectBindings;
	public UTexture2D Thumbnail;
}

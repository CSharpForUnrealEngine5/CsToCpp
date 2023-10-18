namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Variant.h")]
public partial class UVariant : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetParent</summary>
	public UVariantSet GetParent() { return default; }
	///<summary>SetDisplayText</summary>
	public void SetDisplayText(FText NewDisplayText) {}
	///<summary>GetDisplayText</summary>
	public FText GetDisplayText() { return default; }
	///<summary>GetNumActors</summary>
	public int GetNumActors() { return default; }
	///<summary>GetActor</summary>
	public AActor GetActor(int ActorIndex) { return default; }
	///<summary>SwitchOn</summary>
	public void SwitchOn() {}
	///<summary>Returns true if none of our properties are dirty</summary>
	public bool IsActive() { return default; }
	///<summary>Sets the thumbnail to use for this variant. Can receive nullptr to clear it</summary>
	public void SetThumbnailFromTexture(UTexture2D NewThumbnail) {}
	///<summary>SetThumbnailFromFile</summary>
	public void SetThumbnailFromFile(string FilePath) {}
	///<summary>SetThumbnailFromCamera</summary>
	public void SetThumbnailFromCamera(UObject WorldContextObject,FTransform CameraTransform,float FOVDegrees/*=50.0f*/,float MinZ/*=50.0f*/,float Gamma/*=2.2f*/) {}
	///<summary>Sets the thumbnail from the active editor viewport. Doesn&#39;t do anything if the Editor is not available</summary>
	public void SetThumbnailFromEditorViewport() {}
	///<summary>Gets the thumbnail currently used for this variant</summary>
	public UTexture2D GetThumbnail() { return default; }
	///<summary>Returns all the variants that have this variant as a dependency</summary>
	public TArray<UVariant> GetDependents(ULevelVariantSets LevelVariantSets,bool bOnlyEnabledDependencies) { return default; }
	///<summary>AddDependency</summary>
	public int AddDependency(FVariantDependency Dependency) { return default; }
	///<summary>Get the dependency at index &#39;Index&#39; by value. Will crash if index is invalid</summary>
	public FVariantDependency GetDependency(int Index) { return default; }
	///<summary>SetDependency</summary>
	public void SetDependency(int Index,FVariantDependency Dependency) {}
	///<summary>DeleteDependency</summary>
	public void DeleteDependency(int Index) {}
	///<summary>GetNumDependencies</summary>
	public int GetNumDependencies() { return default; }
	///<summary>Dependencies</summary>
	public TArray<FVariantDependency> Dependencies;
	///<summary>The display name used to be a property. Use the non-deprecated, non-property version from now on</summary>
	public FText DisplayText_DEPRECATED;
	///<summary>ObjectBindings</summary>
	public TArray<UVariantObjectBinding> ObjectBindings;
	///<summary>Thumbnail</summary>
	public UTexture2D Thumbnail;
}

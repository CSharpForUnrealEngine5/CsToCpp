#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmark.h")]
public partial class UVPBookmark : UBookmarkBase {
// VPBookmark
	public bool bIsActive;
	public TLazyObjectPtr<AActor> OwnedActor;
	public FVPBookmarkCreationContext CreationContext;
	public FVPBookmarkViewportData CachedViewportData;
	public bool IsActive() { return default; }
	public int GetBookmarkIndex() { return default; }
	public UObject GetAssociatedBookmarkActor() { return default; }
	public string GetDisplayName() { return default; }
}

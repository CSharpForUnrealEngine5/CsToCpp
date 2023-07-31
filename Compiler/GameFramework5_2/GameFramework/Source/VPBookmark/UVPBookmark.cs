#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmark.h")]
public partial class UVPBookmark : UBookmarkBase {
	///<summary>bIsActive</summary>
	public bool bIsActive;
	///<summary>OwnedActor</summary>
	public TLazyObjectPtr<AActor> OwnedActor;
	///<summary>CreationContext</summary>
	public FVPBookmarkCreationContext CreationContext;
	///<summary>CachedViewportData</summary>
	public FVPBookmarkViewportData CachedViewportData;
	///<summary>IsActive</summary>
	public  bool IsActive() { return default; }
	///<summary>GetBookmarkIndex</summary>
	public  int GetBookmarkIndex() { return default; }
	///<summary>GetAssociatedBookmarkActor</summary>
	public  AActor GetAssociatedBookmarkActor() { return default; }
	///<summary>GetDisplayName</summary>
	public  string GetDisplayName() { return default; }
}

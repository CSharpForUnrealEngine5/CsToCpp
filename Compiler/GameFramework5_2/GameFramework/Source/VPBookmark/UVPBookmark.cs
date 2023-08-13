namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmark.h")]
public partial class UVPBookmark : UBookmarkBase {
	public static UClass StaticClass() {return default;}
	///<summary>bIsActive</summary>
	public bool bIsActive;
	///<summary>OwnedActor</summary>
	public TLazyObjectPtr<AActor> OwnedActor;
	///<summary>CreationContext</summary>
	public FVPBookmarkCreationContext CreationContext;
	///<summary>CachedViewportData</summary>
	public FVPBookmarkViewportData CachedViewportData;
	///<summary>IsActive</summary>
	public bool IsActive() { return default; }
	///<summary>GetBookmarkIndex</summary>
	public int GetBookmarkIndex() { return default; }
	///<summary>GetAssociatedBookmarkActor</summary>
	public AActor GetAssociatedBookmarkActor() { return default; }
	///<summary>GetDisplayName</summary>
	public FText GetDisplayName() { return default; }
}

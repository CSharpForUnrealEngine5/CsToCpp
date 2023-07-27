#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVPBookmarkProvider.h")]
public partial class UVPBookmarkProvider : UInterface {
// VPBookmarkProvider
	public  void OnBookmarkActivation(UVPBookmark Bookmark,bool bActivate) {}
	public  void OnBookmarkChanged(UVPBookmark Bookmark) {}
	public  void UpdateBookmarkSplineMeshIndicator() {}
	public  void HideBookmarkSplineMeshIndicator() {}
	public  void GenerateBookmarkName() {}
}

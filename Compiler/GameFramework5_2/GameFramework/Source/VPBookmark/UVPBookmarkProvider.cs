namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVPBookmarkProvider.h")]
public partial class UVPBookmarkProvider : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>OnBookmarkActivation</summary>
	public void OnBookmarkActivation(UVPBookmark Bookmark,bool bActivate) {}
	///<summary>OnBookmarkChanged</summary>
	public void OnBookmarkChanged(UVPBookmark Bookmark) {}
	///<summary>UpdateBookmarkSplineMeshIndicator</summary>
	public void UpdateBookmarkSplineMeshIndicator() {}
	///<summary>HideBookmarkSplineMeshIndicator</summary>
	public void HideBookmarkSplineMeshIndicator() {}
	///<summary>GenerateBookmarkName</summary>
	public void GenerateBookmarkName() {}
}

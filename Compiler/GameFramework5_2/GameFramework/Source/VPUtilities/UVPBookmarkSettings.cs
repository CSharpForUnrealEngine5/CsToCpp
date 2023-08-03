#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkSettings.h")]
public partial class UVPBookmarkSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bookmark mesh to use for Bookmark actor</summary>
	public FSoftObjectPath BookmarkMeshPath;
	///<summary>Bookmark mesh material to use for Bookmark actor</summary>
	public FSoftObjectPath BookmarkMaterialPath;
	///<summary>Bookmark spline mesh to use for Bookmark actor</summary>
	public FSoftObjectPath BookmarkSplineMeshPath;
	///<summary>Bookmark spline mesh material to use for Bookmark actor</summary>
	public FSoftObjectPath BookmarkSplineMeshMaterialPath;
	///<summary>Bookmark label material class to use for Bookmark actor</summary>
	public FSoftObjectPath BookmarkLabelMaterialPath;
}

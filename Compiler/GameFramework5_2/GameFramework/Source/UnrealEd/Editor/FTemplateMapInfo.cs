#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used by new level dialog.</summary>
[CppInclude("Editor/TemplateMapInfo.h")]
public partial struct FTemplateMapInfo {
	public TSoftObjectPtr<UTexture2D> ThumbnailTexture;
	public FSoftObjectPath Thumbnail;
	public FSoftObjectPath Map;
	public string DisplayName;
	public string Category;
}

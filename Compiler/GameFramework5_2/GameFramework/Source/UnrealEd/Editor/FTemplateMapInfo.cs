#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/TemplateMapInfo.h")]
///<summary>Used by new level dialog.</summary>
public partial struct FTemplateMapInfo {
// TemplateMapInfo
	public TSoftObjectPtr<UTexture2D> ThumbnailTexture;
	public FSoftObjectPath Thumbnail;
	public FSoftObjectPath Map;
	public string DisplayName;
	public string Category;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used by new level dialog.</summary>
[CppInclude("Editor/TemplateMapInfo.h")]
public partial struct FTemplateMapInfo {
	public TSoftObjectPtr<UTexture2D> ThumbnailTexture;
	public FSoftObjectPath Thumbnail;
	public FSoftObjectPath Map;
	public FText DisplayName;
	public string Category;
}

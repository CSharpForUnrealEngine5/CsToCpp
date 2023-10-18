namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFImageBlock.h")]
public partial struct FUIFrameworkImageBlockData {
	public FLinearColor Tint;
	public TSoftObjectPtr<UObject> ResourceObject;
	public FVector2f DesiredSize;
	public ESlateBrushTileType Tiling;
	public bool bUseTextureSize;
}

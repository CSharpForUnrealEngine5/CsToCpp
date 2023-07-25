#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectUIData.h")]
public partial struct FMutableParamUIMetadata {
// MutableParamUIMetadata
	public string ObjectFriendlyName;
	public string UISectionName;
	public int UIOrder;
	public TSoftObjectPtr<UTexture2D> UIThumbnail;
	public TMap<string,string> ExtraInformation;
	public TMap<string,TSoftObjectPtr<UObject>> ExtraAssets;
	public float MinimumValue;
	public float MaximumValue;
}

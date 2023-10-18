namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectUIData.h")]
public partial struct FMutableParamUIMetadata {
	public string ObjectFriendlyName;
	public string UISectionName;
	public int UIOrder;
	public TSoftObjectPtr<UTexture2D> UIThumbnail;
	public TMap<string,string> ExtraInformation;
	public TMap<string,TSoftObjectPtr<UObject>> ExtraAssets;
	public float MinimumValue;
	public float MaximumValue;
}

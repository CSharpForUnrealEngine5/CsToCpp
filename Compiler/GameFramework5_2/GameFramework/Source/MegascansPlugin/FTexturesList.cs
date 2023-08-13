namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSAssetImportData.h")]
public partial struct FTexturesList {
	public string textureID;
	public string type;
	public string resolution;
	public string name;
	public string path;
	public bool isChannelPacked;
	public TArray<FChannelPackedInfo> channelPackInfo;
	public TArray<FTextureUsage> pluggedIn;
}

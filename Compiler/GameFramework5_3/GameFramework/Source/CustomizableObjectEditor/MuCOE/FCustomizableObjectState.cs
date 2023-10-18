namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeObject.h")]
public partial struct FCustomizableObjectState {
	public string Name;
	public TArray<string> RuntimeParameters;
	public ETextureCompressionStrategy TextureCompressionStrategy;
	public bool bLiveUpdateMode;
	public bool bReuseInstanceTextures;
	public bool bBuildOnlyFirstLOD;
	public TMap<string,int> NumExtraLODsToBuildPerPlatform;
	public TMap<string,string> ForcedParameterValues;
	public FMutableParamUIMetadata StateUIMetadata;
	public bool bDontCompressRuntimeTextures_DEPRECATED;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeObject.h")]
public partial struct FCustomizableObjectState {
// CustomizableObjectState
	public string Name;
	public TArray<string> RuntimeParameters;
	public bool bDontCompressRuntimeTextures;
	public bool bLiveUpdateMode;
	public bool bReuseInstanceTextures;
	public bool bBuildOnlyFirstLOD;
	public TMap<string,string> ForcedParameterValues;
	public FMutableParamUIMetadata StateUIMetadata;
}

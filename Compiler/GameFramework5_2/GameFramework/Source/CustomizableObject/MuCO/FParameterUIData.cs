#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectUIData.h")]
public partial struct FParameterUIData {
// ParameterUIData
	public string Name;
	public FMutableParamUIMetadata ParamUIMetadata;
	public EMutableParameterType Type;
	public TArray<FIntegerParameterUIData> ArrayIntegerParameterOption;
	public ECustomizableObjectGroupType IntegerParameterGroupType;
	public bool bDontCompressRuntimeTextures;
	public bool bLiveUpdateMode;
	public bool bReuseInstanceTextures;
	public TMap<string,string> ForcedParameterValues;
}

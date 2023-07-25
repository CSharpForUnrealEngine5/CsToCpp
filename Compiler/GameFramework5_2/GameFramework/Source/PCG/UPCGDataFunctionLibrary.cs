#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGData.h")]
public partial class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary {
// PCGDataFunctionLibrary
	public TArray<FPCGTaggedData> GetInputs(FPCGDataCollection InCollection) { return default; }
	public TArray<FPCGTaggedData> GetInputsByPin(FPCGDataCollection InCollection,string InPinLabel) { return default; }
	public TArray<FPCGTaggedData> GetTaggedInputs(FPCGDataCollection InCollection,string InTag) { return default; }
	public TArray<FPCGTaggedData> GetParams(FPCGDataCollection InCollection) { return default; }
	public TArray<FPCGTaggedData> GetParamsByPin(FPCGDataCollection InCollection,string InPinLabel) { return default; }
	public TArray<FPCGTaggedData> GetTaggedParams(FPCGDataCollection InCollection,string InTag) { return default; }
	public TArray<FPCGTaggedData> GetAllSettings(FPCGDataCollection InCollection) { return default; }
}

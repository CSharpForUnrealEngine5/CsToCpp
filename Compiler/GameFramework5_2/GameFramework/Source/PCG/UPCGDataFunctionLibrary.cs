#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGData.h")]
public partial class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary {
// PCGDataFunctionLibrary
	public static TArray<FPCGTaggedData> GetInputs(FPCGDataCollection InCollection) { return default; }
	public static TArray<FPCGTaggedData> GetInputsByPin(FPCGDataCollection InCollection,string InPinLabel) { return default; }
	public static TArray<FPCGTaggedData> GetTaggedInputs(FPCGDataCollection InCollection,string InTag) { return default; }
	public static TArray<FPCGTaggedData> GetParams(FPCGDataCollection InCollection) { return default; }
	public static TArray<FPCGTaggedData> GetParamsByPin(FPCGDataCollection InCollection,string InPinLabel) { return default; }
	public static TArray<FPCGTaggedData> GetTaggedParams(FPCGDataCollection InCollection,string InTag) { return default; }
	public static TArray<FPCGTaggedData> GetAllSettings(FPCGDataCollection InCollection) { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGData.h")]
public partial class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Blueprint methods to support interaction with FPCGDataCollection</summary>
	public static TArray<FPCGTaggedData> GetInputs(FPCGDataCollection InCollection) { return default; }
	///<summary>GetInputsByPin</summary>
	public static TArray<FPCGTaggedData> GetInputsByPin(FPCGDataCollection InCollection,string InPinLabel) { return default; }
	///<summary>GetTaggedInputs</summary>
	public static TArray<FPCGTaggedData> GetTaggedInputs(FPCGDataCollection InCollection,string InTag) { return default; }
	///<summary>GetParams</summary>
	public static TArray<FPCGTaggedData> GetParams(FPCGDataCollection InCollection) { return default; }
	///<summary>GetParamsByPin</summary>
	public static TArray<FPCGTaggedData> GetParamsByPin(FPCGDataCollection InCollection,string InPinLabel) { return default; }
	///<summary>GetTaggedParams</summary>
	public static TArray<FPCGTaggedData> GetTaggedParams(FPCGDataCollection InCollection,string InTag) { return default; }
	///<summary>GetAllSettings</summary>
	public static TArray<FPCGTaggedData> GetAllSettings(FPCGDataCollection InCollection) { return default; }
}

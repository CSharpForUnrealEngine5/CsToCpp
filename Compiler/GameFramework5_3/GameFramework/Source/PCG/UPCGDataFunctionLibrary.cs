namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGData.h")]
public partial class UPCGDataFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Gets all inputs of the given class type, returning matching tagged data in the OutTaggedData value too</summary>
	public static TArray<UPCGData> GetTypedInputs(FPCGDataCollection InCollection,TArray<FPCGTaggedData> OutTaggedData,UClass InDataTypeClass/*=nullptr*/) { return default; }
	///<summary>Gets all inputs of the given class type and on the given pin, returning matching tagged data in the OutTaggedData value too</summary>
	public static TArray<UPCGData> GetTypedInputsByPin(FPCGDataCollection InCollection,FPCGPinProperties InPin,TArray<FPCGTaggedData> OutTaggedData,UClass InDataTypeClass/*=nullptr*/) { return default; }
	///<summary>Gets all inputs of the given class type and on the given pin label, returning matching tagged data in the OutTaggedData value too</summary>
	public static TArray<UPCGData> GetTypedInputsByPinLabel(FPCGDataCollection InCollection,FName InPinLabel,TArray<FPCGTaggedData> OutTaggedData,UClass InDataTypeClass/*=nullptr*/) { return default; }
	///<summary>Gets all inputs of the given class type and having the provided tag, returning matching tagged data in the OutTaggedData value too</summary>
	public static TArray<UPCGData> GetTypedInputsByTag(FPCGDataCollection InCollection,string InTag,TArray<FPCGTaggedData> OutTaggedData,UClass InDataTypeClass/*=nullptr*/) { return default; }
	///<summary>Adds a data object to a given collection, simpler usage than making a PCGTaggedData object</summary>
	public static void AddToCollection(FPCGDataCollection InCollection,UPCGData InData,FName InPinLabel,TArray<string> InTags) {}
	///<summary>Blueprint methods to support interaction with FPCGDataCollection</summary>
	public static TArray<FPCGTaggedData> GetInputs(FPCGDataCollection InCollection) { return default; }
	///<summary>GetInputsByPinLabel</summary>
	public static TArray<FPCGTaggedData> GetInputsByPinLabel(FPCGDataCollection InCollection,FName InPinLabel) { return default; }
	///<summary>GetInputsByTag</summary>
	public static TArray<FPCGTaggedData> GetInputsByTag(FPCGDataCollection InCollection,string InTag) { return default; }
	///<summary>GetParams</summary>
	public static TArray<FPCGTaggedData> GetParams(FPCGDataCollection InCollection) { return default; }
	///<summary>GetParamsByPinLabel</summary>
	public static TArray<FPCGTaggedData> GetParamsByPinLabel(FPCGDataCollection InCollection,FName InPinLabel) { return default; }
	///<summary>GetParamsByTag</summary>
	public static TArray<FPCGTaggedData> GetParamsByTag(FPCGDataCollection InCollection,string InTag) { return default; }
	///<summary>GetAllSettings</summary>
	public static TArray<FPCGTaggedData> GetAllSettings(FPCGDataCollection InCollection) { return default; }
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXSubsystem.h")]
///<summary>UDMXSubsystem</summary>
public partial class UDMXSubsystem : UEngineSubsystem {
// DMXSubsystem
	public void SendDMX(UObject FixturePatch,TMap<FDMXAttributeName,int> AttributeMap,EDMXSendResult OutResult) {}
	public void SendDMXRaw(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TMap<int,byte> AddressValueMap,EDMXSendResult OutResult) {}
	public void SendDMXToOutputPort(FDMXOutputPortReference OutputPortReference,TMap<int,byte> ChannelToValueMap,int LocalUniverse/*=1*/) {}
	public void GetRawBuffer(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TArray<byte> DMXBuffer) {}
	public void GetDMXDataFromInputPort(FDMXInputPortReference InputPortReference,TArray<byte> DMXData,int LocalUniverse/*=1*/) {}
	public void GetDMXDataFromOutputPort(FDMXOutputPortReference OutputPortReference,TArray<byte> DMXData,int LocalUniverse/*=1*/) {}
	public void GetAllFixturesOfType(FDMXEntityFixtureTypeRef FixtureType,TArray<UObject> OutResult) {}
	public void GetAllFixturesOfCategory(UObject DMXLibrary,FDMXFixtureCategory Category,TArray<UObject> OutResult) {}
	public void GetAllFixturesInUniverse(UObject DMXLibrary,int UniverseId,TArray<UObject> OutResult) {}
	public void GetFixtureAttributes(UObject InFixturePatch,TArray<byte> DMXBuffer,TMap<FDMXAttributeName,int> OutResult) {}
	public TArray<UObject> GetAllFixturesWithTag(UObject DMXLibrary,string CustomTag) { return default; }
	public TArray<UObject> GetAllFixturesInLibrary(UObject DMXLibrary) { return default; }
	public UObject GetFixtureByName(UObject DMXLibrary,string Name) { return default; }
	public TArray<UObject> GetAllFixtureTypesInLibrary(UObject DMXLibrary) { return default; }
	public UObject GetFixtureTypeByName(UObject DMXLibrary,string Name) { return default; }
	public void GetAllUniversesInController(UObject DMXLibrary,string ControllerName,TArray<int> OutResult) {}
	public TArray<UObject> GetAllControllersInLibrary(UObject DMXLibrary) { return default; }
	public UObject GetControllerByName(UObject DMXLibrary,string Name) { return default; }
	public TArray<UObject> GetAllDMXLibraries() { return default; }
	public int BytesToInt(TArray<byte> Bytes,bool bUseLSB/*=false*/) { return default; }
	public float BytesToNormalizedValue(TArray<byte> Bytes,bool bUseLSB/*=false*/) { return default; }
	public void NormalizedValueToBytes(float InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB/*=false*/) {}
	public void IntValueToBytes(int InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB/*=false*/) {}
	public float IntToNormalizedValue(int InValue,EDMXFixtureSignalFormat InSignalFormat) { return default; }
	public float GetNormalizedAttributeValue(UObject InFixturePatch,FDMXAttributeName InFunctionAttribute,int InValue) { return default; }
	public UObject GetFixtureType(FDMXEntityFixtureTypeRef InFixtureType) { return default; }
	public UObject GetFixturePatch(FDMXEntityFixturePatchRef InFixturePatch) { return default; }
	public bool GetFunctionsMap(UObject InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap) { return default; }
	public bool GetFunctionsMapForPatch(UObject InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap) { return default; }
	public int GetFunctionsValue(string FunctionAttributeName,TMap<FDMXAttributeName,int> InAttributesMap) { return default; }
	public bool PatchIsOfSelectedType(UObject InFixturePatch,string RefTypeValue) { return default; }
	public UObject GetDMXSubsystem_Pure() { return default; }
	public UObject GetDMXSubsystem_Callable() { return default; }
	public string GetAttributeLabel(FDMXAttributeName AttributeName) { return default; }
	public FProtocolReceivedDelegate OnProtocolReceived_DEPRECATED;
	public bool SetMatrixCellValue(UObject FixturePatch,FIntPoint Coordinate,FDMXAttributeName Attribute,int Value) { return default; }
	public bool GetMatrixCellValue(UObject FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeValueMap) { return default; }
	public bool GetMatrixCellChannelsRelative(UObject FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	public bool GetMatrixCellChannelsAbsolute(UObject FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	public bool GetMatrixProperties(UObject FixturePatch,FDMXFixtureMatrix MatrixProperties) { return default; }
	public bool GetCellAttributes(UObject FixturePatch,TArray<FDMXAttributeName> CellAttributes) { return default; }
	public bool GetMatrixCell(UObject FixturePatch,FIntPoint Coordinate,FDMXCell Cell) { return default; }
	public bool GetAllMatrixCells(UObject FixturePatch,TArray<FDMXCell> Cells) { return default; }
	public void PixelMappingDistributionSort(EDMXPixelMappingDistribution InDistribution,int InNumXPanels,int InNumYPanels,TArray<int> InUnorderedList,TArray<int> OutSortedList) {}
	public void OnAssetRegistryAddedAsset(FAssetData Asset) {}
	public void OnAssetRegistryRemovedAsset(FAssetData Asset) {}
	public TArray<UDMXLibrary> LoadedDMXLibraries;
}

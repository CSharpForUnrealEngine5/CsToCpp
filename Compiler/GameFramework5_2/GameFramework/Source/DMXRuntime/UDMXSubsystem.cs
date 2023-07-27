#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXSubsystem.h")]
///<summary>UDMXSubsystem</summary>
public partial class UDMXSubsystem : UEngineSubsystem {
// DMXSubsystem
	public  void SendDMX(UDMXEntityFixturePatch FixturePatch,TMap<FDMXAttributeName,int> AttributeMap,EDMXSendResult OutResult) {}
	public  void SendDMXRaw(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TMap<int,byte> AddressValueMap,EDMXSendResult OutResult) {}
	public static void SendDMXToOutputPort(FDMXOutputPortReference OutputPortReference,TMap<int,byte> ChannelToValueMap,int LocalUniverse/*=1*/) {}
	public  void GetRawBuffer(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TArray<byte> DMXBuffer) {}
	public static void GetDMXDataFromInputPort(FDMXInputPortReference InputPortReference,TArray<byte> DMXData,int LocalUniverse/*=1*/) {}
	public static void GetDMXDataFromOutputPort(FDMXOutputPortReference OutputPortReference,TArray<byte> DMXData,int LocalUniverse/*=1*/) {}
	public  void GetAllFixturesOfType(FDMXEntityFixtureTypeRef FixtureType,TArray<UDMXEntityFixturePatch> OutResult) {}
	public  void GetAllFixturesOfCategory(UDMXLibrary DMXLibrary,FDMXFixtureCategory Category,TArray<UDMXEntityFixturePatch> OutResult) {}
	public  void GetAllFixturesInUniverse(UDMXLibrary DMXLibrary,int UniverseId,TArray<UDMXEntityFixturePatch> OutResult) {}
	public  void GetFixtureAttributes(UDMXEntityFixturePatch InFixturePatch,TArray<byte> DMXBuffer,TMap<FDMXAttributeName,int> OutResult) {}
	public  TArray<UDMXEntityFixturePatch> GetAllFixturesWithTag(UDMXLibrary DMXLibrary,string CustomTag) { return default; }
	public  TArray<UDMXEntityFixturePatch> GetAllFixturesInLibrary(UDMXLibrary DMXLibrary) { return default; }
	public  UDMXEntityFixturePatch GetFixtureByName(UDMXLibrary DMXLibrary,string Name) { return default; }
	public  TArray<UDMXEntityFixtureType> GetAllFixtureTypesInLibrary(UDMXLibrary DMXLibrary) { return default; }
	public  UDMXEntityFixtureType GetFixtureTypeByName(UDMXLibrary DMXLibrary,string Name) { return default; }
	public  void GetAllUniversesInController(UDMXLibrary DMXLibrary,string ControllerName,TArray<int> OutResult) {}
	public  TArray<UDMXEntityController> GetAllControllersInLibrary(UDMXLibrary DMXLibrary) { return default; }
	public  UDMXEntityController GetControllerByName(UDMXLibrary DMXLibrary,string Name) { return default; }
	public  TArray<UDMXLibrary> GetAllDMXLibraries() { return default; }
	public  int BytesToInt(TArray<byte> Bytes,bool bUseLSB/*=false*/) { return default; }
	public  float BytesToNormalizedValue(TArray<byte> Bytes,bool bUseLSB/*=false*/) { return default; }
	public  void NormalizedValueToBytes(float InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB/*=false*/) {}
	public static void IntValueToBytes(int InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB/*=false*/) {}
	public  float IntToNormalizedValue(int InValue,EDMXFixtureSignalFormat InSignalFormat) { return default; }
	public  float GetNormalizedAttributeValue(UDMXEntityFixturePatch InFixturePatch,FDMXAttributeName InFunctionAttribute,int InValue) { return default; }
	public  UDMXEntityFixtureType GetFixtureType(FDMXEntityFixtureTypeRef InFixtureType) { return default; }
	public  UDMXEntityFixturePatch GetFixturePatch(FDMXEntityFixturePatchRef InFixturePatch) { return default; }
	public  bool GetFunctionsMap(UDMXEntityFixturePatch InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap) { return default; }
	public  bool GetFunctionsMapForPatch(UDMXEntityFixturePatch InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap) { return default; }
	public  int GetFunctionsValue(string FunctionAttributeName,TMap<FDMXAttributeName,int> InAttributesMap) { return default; }
	public  bool PatchIsOfSelectedType(UDMXEntityFixturePatch InFixturePatch,string RefTypeValue) { return default; }
	public static UDMXSubsystem GetDMXSubsystem_Pure() { return default; }
	public static UDMXSubsystem GetDMXSubsystem_Callable() { return default; }
	public  string GetAttributeLabel(FDMXAttributeName AttributeName) { return default; }
	public FProtocolReceivedDelegate OnProtocolReceived_DEPRECATED;
	public  bool SetMatrixCellValue(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,FDMXAttributeName Attribute,int Value) { return default; }
	public  bool GetMatrixCellValue(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeValueMap) { return default; }
	public  bool GetMatrixCellChannelsRelative(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	public  bool GetMatrixCellChannelsAbsolute(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	public  bool GetMatrixProperties(UDMXEntityFixturePatch FixturePatch,FDMXFixtureMatrix MatrixProperties) { return default; }
	public  bool GetCellAttributes(UDMXEntityFixturePatch FixturePatch,TArray<FDMXAttributeName> CellAttributes) { return default; }
	public  bool GetMatrixCell(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,FDMXCell Cell) { return default; }
	public  bool GetAllMatrixCells(UDMXEntityFixturePatch FixturePatch,TArray<FDMXCell> Cells) { return default; }
	public  void PixelMappingDistributionSort(EDMXPixelMappingDistribution InDistribution,int InNumXPanels,int InNumYPanels,TArray<int> InUnorderedList,TArray<int> OutSortedList) {}
	public  void OnAssetRegistryAddedAsset(FAssetData Asset) {}
	public  void OnAssetRegistryRemovedAsset(FAssetData Asset) {}
	public TArray<UDMXLibrary> LoadedDMXLibraries;
}

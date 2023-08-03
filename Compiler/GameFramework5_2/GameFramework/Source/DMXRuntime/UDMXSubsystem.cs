#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDMXSubsystem</summary>
[CppInclude("DMXSubsystem.h")]
public partial class UDMXSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Send DMX using function names and integer values.</summary>
	public  void SendDMX(UDMXEntityFixturePatch FixturePatch,TMap<FDMXAttributeName,int> AttributeMap,EDMXSendResult OutResult) {}
	///<summary>DEPRECATED 4.27</summary>
	public  void SendDMXRaw(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TMap<int,byte> AddressValueMap,EDMXSendResult OutResult) {}
	///<summary>Sends DMX Values over the Output Port</summary>
	public static void SendDMXToOutputPort(FDMXOutputPortReference OutputPortReference,TMap<int,byte> ChannelToValueMap,int LocalUniverse/*=1*/) {}
	///<summary>DEPRECATED 4.27</summary>
	public  void GetRawBuffer(FDMXProtocolName SelectedProtocol,int RemoteUniverse,TArray<byte> DMXBuffer) {}
	///<summary>Gets accumulated latest DMX Values from the Input Port (all that&#39;s been received since Begin Play)</summary>
	public static void GetDMXDataFromInputPort(FDMXInputPortReference InputPortReference,TArray<byte> DMXData,int LocalUniverse/*=1*/) {}
	///<summary>Gets accumulated latest DMX Values from the Output Port  (all that&#39;s been sent since Begin Play)</summary>
	public static void GetDMXDataFromOutputPort(FDMXOutputPortReference OutputPortReference,TArray<byte> DMXData,int LocalUniverse/*=1*/) {}
	///<summary>Return reference to array of Fixture Patch objects of a given type.</summary>
	public  void GetAllFixturesOfType(FDMXEntityFixtureTypeRef FixtureType,TArray<UDMXEntityFixturePatch> OutResult) {}
	///<summary>Return reference to array of Fixture Patch objects of a given category.</summary>
	public  void GetAllFixturesOfCategory(UDMXLibrary DMXLibrary,FDMXFixtureCategory Category,TArray<UDMXEntityFixturePatch> OutResult) {}
	///<summary>Return reference to array of Fixture Patch objects in a given universe.</summary>
	public  void GetAllFixturesInUniverse(UDMXLibrary DMXLibrary,int UniverseId,TArray<UDMXEntityFixturePatch> OutResult) {}
	///<summary>Return map with all DMX functions and their associated values given DMX buffer and desired universe.</summary>
	public  void GetFixtureAttributes(UDMXEntityFixturePatch InFixturePatch,TArray<byte> DMXBuffer,TMap<FDMXAttributeName,int> OutResult) {}
	///<summary>Return reference to array of Fixture Patch objects with a given tag.</summary>
	public  TArray<UDMXEntityFixturePatch> GetAllFixturesWithTag(UDMXLibrary DMXLibrary,string CustomTag) { return default; }
	///<summary>Return reference to array of Fixture Patch objects in library.</summary>
	public  TArray<UDMXEntityFixturePatch> GetAllFixturesInLibrary(UDMXLibrary DMXLibrary) { return default; }
	///<summary>Return reference to Fixture Patch object with a given name.</summary>
	public  UDMXEntityFixturePatch GetFixtureByName(UDMXLibrary DMXLibrary,string Name) { return default; }
	///<summary>Return reference to array of Fixture Types objects in library.</summary>
	public  TArray<UDMXEntityFixtureType> GetAllFixtureTypesInLibrary(UDMXLibrary DMXLibrary) { return default; }
	///<summary>Return reference to Fixture Type object with a given name.</summary>
	public  UDMXEntityFixtureType GetFixtureTypeByName(UDMXLibrary DMXLibrary,string Name) { return default; }
	///<summary>DEPRECATED 4.27</summary>
	public  void GetAllUniversesInController(UDMXLibrary DMXLibrary,string ControllerName,TArray<int> OutResult) {}
	///<summary>DEPRECATED 4.27</summary>
	public  TArray<UDMXEntityController> GetAllControllersInLibrary(UDMXLibrary DMXLibrary) { return default; }
	///<summary>DEPRECATED 4.27</summary>
	public  UDMXEntityController GetControllerByName(UDMXLibrary DMXLibrary,string Name) { return default; }
	///<summary>Return reference to array of DMX Library objects.</summary>
	public  TArray<UDMXLibrary> GetAllDMXLibraries() { return default; }
	///<summary>Return integer given an array of bytes. Up to the first 4 bytes in the array will be used for the conversion.</summary>
	public  int BytesToInt(TArray<byte> Bytes,bool bUseLSB/*=false*/) { return default; }
	///<summary>Return normalized value given an array of bytes. Up to the first 4 bytes in the array will be used for the conversion.</summary>
	public  float BytesToNormalizedValue(TArray<byte> Bytes,bool bUseLSB/*=false*/) { return default; }
	///<summary>Return the Bytes format of Value in the desired Signal Format.</summary>
	public  void NormalizedValueToBytes(float InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB/*=false*/) {}
	///<summary>Return the Bytes format of Value in the desired Signal Format.</summary>
	public static void IntValueToBytes(int InValue,EDMXFixtureSignalFormat InSignalFormat,TArray<byte> Bytes,bool bUseLSB/*=false*/) {}
	///<summary>Return the normalized value of an Int value from the specified Signal Format.</summary>
	public  float IntToNormalizedValue(int InValue,EDMXFixtureSignalFormat InSignalFormat) { return default; }
	///<summary>Return the normalized value of an Int value from a Fixture Patch function.</summary>
	public  float GetNormalizedAttributeValue(UDMXEntityFixturePatch InFixturePatch,FDMXAttributeName InFunctionAttribute,int InValue) { return default; }
	///<summary>Creates a literal UDMXEntityFixturePatch reference</summary>
	public  UDMXEntityFixtureType GetFixtureType(FDMXEntityFixtureTypeRef InFixtureType) { return default; }
	///<summary>Creates a literal UDMXEntityFixturePatch reference</summary>
	public  UDMXEntityFixturePatch GetFixturePatch(FDMXEntityFixturePatchRef InFixturePatch) { return default; }
	///<summary>Gets a function map based on you active mode from FixturePatch</summary>
	public  bool GetFunctionsMap(UDMXEntityFixturePatch InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap) { return default; }
	///<summary>Gets a function map based on you active mode from FixturePatch, but instead of passing a Protocol as parameters, it looks for</summary>
	public  bool GetFunctionsMapForPatch(UDMXEntityFixturePatch InFixturePatch,TMap<FDMXAttributeName,int> OutAttributesMap) { return default; }
	///<summary>Gets function channel value by input function name</summary>
	public  int GetFunctionsValue(string FunctionAttributeName,TMap<FDMXAttributeName,int> InAttributesMap) { return default; }
	///<summary>Checks if a FixturePatchs is of a given FixtureType</summary>
	public  bool PatchIsOfSelectedType(UDMXEntityFixturePatch InFixturePatch,string RefTypeValue) { return default; }
	///<summary>Get a DMX Subsystem, pure version</summary>
	public static UDMXSubsystem GetDMXSubsystem_Pure() { return default; }
	///<summary>Get a DMX Subsystem, callable version</summary>
	public static UDMXSubsystem GetDMXSubsystem_Callable() { return default; }
	///<summary>Gets the FName for a FDMXAttributeName, since structs can&#39;t have UFUCNTIONS to create a getter</summary>
	public  string GetAttributeLabel(FDMXAttributeName AttributeName) { return default; }
	///<summary>OnProtocolReceived_DEPRECATED</summary>
	public FProtocolReceivedDelegate OnProtocolReceived_DEPRECATED;
	///<summary>Cell coordinate X/Y</summary>
	public  bool SetMatrixCellValue(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,FDMXAttributeName Attribute,int Value) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public  bool GetMatrixCellValue(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeValueMap) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public  bool GetMatrixCellChannelsRelative(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public  bool GetMatrixCellChannelsAbsolute(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	///<summary>GetMatrixProperties</summary>
	public  bool GetMatrixProperties(UDMXEntityFixturePatch FixturePatch,FDMXFixtureMatrix MatrixProperties) { return default; }
	///<summary>GetCellAttributes</summary>
	public  bool GetCellAttributes(UDMXEntityFixturePatch FixturePatch,TArray<FDMXAttributeName> CellAttributes) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public  bool GetMatrixCell(UDMXEntityFixturePatch FixturePatch,FIntPoint Coordinate,FDMXCell Cell) { return default; }
	///<summary>GetAllMatrixCells</summary>
	public  bool GetAllMatrixCells(UDMXEntityFixturePatch FixturePatch,TArray<FDMXCell> Cells) { return default; }
	///<summary>Sort an array according to the selected distribution pattern.</summary>
	public  void PixelMappingDistributionSort(EDMXPixelMappingDistribution InDistribution,int InNumXPanels,int InNumYPanels,TArray<int> InUnorderedList,TArray<int> OutSortedList) {}
	///<summary>Called when asset registry added an asset</summary>
	public  void OnAssetRegistryAddedAsset(FAssetData Asset) {}
	///<summary>Called when asset registry removed an asset</summary>
	public  void OnAssetRegistryRemovedAsset(FAssetData Asset) {}
	///<summary>Strongly references all libraries at all times</summary>
	public TArray<UDMXLibrary> LoadedDMXLibraries;
}

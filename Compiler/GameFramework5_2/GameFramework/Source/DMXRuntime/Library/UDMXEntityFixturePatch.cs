#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixturePatch.h")]
///<summary>A DMX fixture patch that can be patch to channels in a DMX Universe via the DMX Library Editor.</summary>
public partial class UDMXEntityFixturePatch : UDMXEntity {
// DMXEntityFixturePatch
	public void FDMXOnFixturePatchReceivedDMXDelegate(UObject FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
	public UObject CreateFixturePatchInLibrary(FDMXEntityFixturePatchConstructionParams ConstructionParams,string DesiredName/*=TEXT("")*/,bool bMarkDMXLibraryDirty/*=true*/) { return default; }
	public void RemoveFixturePatchFromLibrary(FDMXEntityFixturePatchRef FixturePatchRef) {}
	public void SendDMX(TMap<FDMXAttributeName,int> AttributeMap) {}
	public FDMXOnFixturePatchReceivedDMXDelegate OnFixturePatchReceivedDMX;
	public void SetFixtureType(UObject NewFixtureType) {}
	public void SetStartingChannel(int NewStartingChannel) {}
	public int GetStartingChannel() { return default; }
	public int GetChannelSpan() { return default; }
	public int GetEndingChannel() { return default; }
	public int UniverseID;
	public bool bAutoAssignAddress_DEPRECATED;
	public int ManualStartingAddress_DEPRECATED;
	public int AutoStartingAddress_DEPRECATED;
	public int StartingChannel;
	public UDMXEntityFixtureType ParentFixtureTypeTemplate;
	public int ActiveMode;
	public FGuid MVRFixtureUUID;
	public TArray<string> CustomTags;
	public FLinearColor EditorColor;
	public bool bReceiveDMXInEditor;
	public int GetRemoteUniverse() { return default; }
	public TArray<FDMXAttributeName> GetAllAttributesInActiveMode() { return default; }
	public TMap<FDMXAttributeName,FDMXFixtureFunction> GetAttributeFunctionsMap() { return default; }
	public TMap<FDMXAttributeName,int> GetAttributeDefaultMap() { return default; }
	public TMap<FDMXAttributeName,int> GetAttributeChannelAssignments() { return default; }
	public TMap<FDMXAttributeName,EDMXFixtureSignalFormat> GetAttributeSignalFormats() { return default; }
	public TMap<FDMXAttributeName,int> ConvertRawMapToAttributeMap(TMap<int,byte> RawMap) { return default; }
	public TMap<int,byte> ConvertAttributeMapToRawMap(TMap<FDMXAttributeName,int> FunctionMap) { return default; }
	public bool IsMapValid(TMap<FDMXAttributeName,int> FunctionMap) { return default; }
	public bool ContainsAttribute(FDMXAttributeName FunctionAttribute) { return default; }
	public TMap<FDMXAttributeName,int> ConvertToValidMap(TMap<FDMXAttributeName,int> FunctionMap) { return default; }
	public TArray<UObject> GetRelevantControllers() { return default; }
	public bool IsInControllerRange(UObject InController) { return default; }
	public bool IsInControllersRange(TArray<UObject> InControllers) { return default; }
	public int GetAttributeValue(FDMXAttributeName Attribute,bool bSuccess) { return default; }
	public float GetNormalizedAttributeValue(FDMXAttributeName Attribute,bool bSuccess) { return default; }
	public void GetAttributesValues(TMap<FDMXAttributeName,int> AttributesValues) {}
	public void GetNormalizedAttributesValues(FDMXNormalizedAttributeValueMap NormalizedAttributesValues) {}
	public bool SendMatrixCellValue(FIntPoint CellCoordinate,FDMXAttributeName Attribute,int Value) { return default; }
	public bool SendMatrixCellValueWithAttributeMap(FIntPoint CellCoordinate,FDMXAttributeName Attribute,int Value,TMap<FDMXAttributeName,int> InAttributeNameChannelMap) { return default; }
	public bool SendNormalizedMatrixCellValue(FIntPoint CellCoordinate,FDMXAttributeName Attribute,float RelativeValue) { return default; }
	public bool GetMatrixCellValues(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> ValuePerAttribute) { return default; }
	public bool GetNormalizedMatrixCellValues(FIntPoint CellCoordinate,TMap<FDMXAttributeName,float> NormalizedValuePerAttribute) { return default; }
	public bool GetMatrixCellChannelsRelative(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	public bool GetMatrixCellChannelsAbsolute(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	public bool GetMatrixCellChannelsAbsoluteWithValidation(FIntPoint InCellCoordinate,TMap<FDMXAttributeName,int> OutAttributeChannelMap) { return default; }
	public bool GetMatrixProperties(FDMXFixtureMatrix MatrixProperties) { return default; }
	public bool GetCellAttributes(TArray<FDMXAttributeName> CellAttributes) { return default; }
	public bool GetMatrixCell(FIntPoint CellCoordinate,FDMXCell Cell) { return default; }
	public bool GetAllMatrixCells(TArray<FDMXCell> Cells) { return default; }
}

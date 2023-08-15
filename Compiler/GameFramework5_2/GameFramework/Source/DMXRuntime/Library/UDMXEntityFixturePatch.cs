namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DMX fixture patch that can be patch to channels in a DMX Universe via the DMX Library Editor.</summary>
[CppInclude("Library/DMXEntityFixturePatch.h")]
public partial class UDMXEntityFixturePatch : UDMXEntity {
	public static UClass StaticClass() {return default;}
	///<summary>FDMXOnFixturePatchReceivedDMXDelegate</summary>
	public void FDMXOnFixturePatchReceivedDMXDelegate(UDMXEntityFixturePatch FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
	///<summary>Creates a new Fixture Patch in the DMX Library using the specified Fixture Type</summary>
	public static UDMXEntityFixturePatch CreateFixturePatchInLibrary(FDMXEntityFixturePatchConstructionParams ConstructionParams,string DesiredName/*=TEXT("")*/,bool bMarkDMXLibraryDirty/*=true*/) { return default; }
	///<summary>Removes a fixture patch from the DMX Library</summary>
	public static void RemoveFixturePatchFromLibrary(FDMXEntityFixturePatchRef FixturePatchRef) {}
	///<summary>Send DMX using attribute names and integer values.</summary>
	public void SendDMX(TMap<FDMXAttributeName,int> AttributeMap) {}
	///<summary>Broadcasts when the patch received dmx</summary>
	public FDMXOnFixturePatchReceivedDMXDelegate OnFixturePatchReceivedDMX;
	///<summary>Sets the fixture type this is using</summary>
	public void SetFixtureType(UDMXEntityFixtureType NewFixtureType) {}
	///<summary>Sets the starting channel of the Fixture Patch.</summary>
	public void SetStartingChannel(int NewStartingChannel) {}
	///<summary>Return the starting channel</summary>
	public int GetStartingChannel() { return default; }
	///<summary>Returns the number of channels this Patch occupies with the Fixture functions from its Active Mode or 0 if the patch has no valid Active Mode</summary>
	public int GetChannelSpan() { return default; }
	///<summary>Returns the last channel of the patch</summary>
	public int GetEndingChannel() { return default; }
	///<summary>The local universe of the patch</summary>
	public int UniverseID;
	///<summary>DEPRECATED 5.1</summary>
	public bool bAutoAssignAddress_DEPRECATED;
	///<summary>DEPRECATED 5.1</summary>
	public int ManualStartingAddress_DEPRECATED;
	///<summary>DEPRECATED 5.1</summary>
	public int AutoStartingAddress_DEPRECATED;
	///<summary>Starting Channel of the Patch</summary>
	public int StartingChannel;
	///<summary>Property to point to the template parent fixture for details panel purposes</summary>
	public UDMXEntityFixtureType ParentFixtureTypeTemplate;
	///<summary>The Index of the Mode in the Fixture Type the Patch uses</summary>
	public int ActiveMode;
	///<summary>The MVR Fixture UUID when used as such</summary>
	public FGuid MVRFixtureUUID;
	///<summary>Custom tags for filtering patches</summary>
	public TArray<FName> CustomTags;
	///<summary>Color when displayed in the fixture patch editor</summary>
	public FLinearColor EditorColor;
	///<summary>If true, the patch receives dmx and raises the OnFixturePatchReceivedDMX event in editor.</summary>
	public bool bReceiveDMXInEditor;
	///<summary>GetRemoteUniverse</summary>
	public int GetRemoteUniverse() { return default; }
	///<summary>Returns an array of valid attributes for the currently active mode.</summary>
	public TArray<FDMXAttributeName> GetAllAttributesInActiveMode() { return default; }
	///<summary>Returns a map of attributes and function names.</summary>
	public TMap<FDMXAttributeName,FDMXFixtureFunction> GetAttributeFunctionsMap() { return default; }
	///<summary>Returns a map of function names and default values.</summary>
	public TMap<FDMXAttributeName,int> GetAttributeDefaultMap() { return default; }
	///<summary>Returns a map of Attributes and their assigned channels</summary>
	public TMap<FDMXAttributeName,int> GetAttributeChannelAssignments() { return default; }
	///<summary>Returns a map of function names and their Data Types.</summary>
	public TMap<FDMXAttributeName,EDMXFixtureSignalFormat> GetAttributeSignalFormats() { return default; }
	///<summary>ConvertRawMapToAttributeMap</summary>
	public TMap<FDMXAttributeName,int> ConvertRawMapToAttributeMap(TMap<int,byte> RawMap) { return default; }
	///<summary>Returns a map of function channels and their values.</summary>
	public TMap<int,byte> ConvertAttributeMapToRawMap(TMap<FDMXAttributeName,int> FunctionMap) { return default; }
	///<summary>Returns true if given function map is valid for this fixture.</summary>
	public bool IsMapValid(TMap<FDMXAttributeName,int> FunctionMap) { return default; }
	///<summary>Returns true if the fixture patch contains the attribute.</summary>
	public bool ContainsAttribute(FDMXAttributeName FunctionAttribute) { return default; }
	///<summary>Returns a map that only contains attributes used this patch.</summary>
	public TMap<FDMXAttributeName,int> ConvertToValidMap(TMap<FDMXAttributeName,int> FunctionMap) { return default; }
	///<summary>GetRelevantControllers</summary>
	public TArray<UDMXEntityController> GetRelevantControllers() { return default; }
	///<summary>IsInControllerRange</summary>
	public bool IsInControllerRange(UDMXEntityController InController) { return default; }
	///<summary>IsInControllersRange</summary>
	public bool IsInControllersRange(TArray<UDMXEntityController> InControllers) { return default; }
	///<summary>Retrieves the value of an Attribute. Will fail and return 0 if the Attribute doesn&#39;t exist.</summary>
	public int GetAttributeValue(FDMXAttributeName Attribute,bool bSuccess) { return default; }
	///<summary>Retrieves the normalized value of an Attribute. Will fail and return 0 if the Attribute doesn&#39;t exist.</summary>
	public float GetNormalizedAttributeValue(FDMXAttributeName Attribute,bool bSuccess) { return default; }
	///<summary>Returns the value of each attribute, or zero if no value was ever received.</summary>
	public void GetAttributesValues(TMap<FDMXAttributeName,int> AttributesValues) {}
	///<summary>Returns the normalized value of each attribute, or zero if no value was ever received.</summary>
	public void GetNormalizedAttributesValues(FDMXNormalizedAttributeValueMap NormalizedAttributesValues) {}
	///<summary>Cell coordinate X/Y</summary>
	public bool SendMatrixCellValue(FIntPoint CellCoordinate,FDMXAttributeName Attribute,int Value) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool SendMatrixCellValueWithAttributeMap(FIntPoint CellCoordinate,FDMXAttributeName Attribute,int Value,TMap<FDMXAttributeName,int> InAttributeNameChannelMap) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool SendNormalizedMatrixCellValue(FIntPoint CellCoordinate,FDMXAttributeName Attribute,float RelativeValue) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool GetMatrixCellValues(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> ValuePerAttribute) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool GetNormalizedMatrixCellValues(FIntPoint CellCoordinate,TMap<FDMXAttributeName,float> NormalizedValuePerAttribute) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool GetMatrixCellChannelsRelative(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool GetMatrixCellChannelsAbsolute(FIntPoint CellCoordinate,TMap<FDMXAttributeName,int> AttributeChannelMap) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool GetMatrixCellChannelsAbsoluteWithValidation(FIntPoint InCellCoordinate,TMap<FDMXAttributeName,int> OutAttributeChannelMap) { return default; }
	///<summary>Gets the Matrix Fixture properties, returns false if the patch is not using a matrix fixture</summary>
	public bool GetMatrixProperties(FDMXFixtureMatrix MatrixProperties) { return default; }
	///<summary>Gets all attributes names of a cell</summary>
	public bool GetCellAttributes(TArray<FDMXAttributeName> CellAttributes) { return default; }
	///<summary>Cell coordinate X/Y</summary>
	public bool GetMatrixCell(FIntPoint CellCoordinate,FDMXCell Cell) { return default; }
	///<summary>Gets all matrix cells</summary>
	public bool GetAllMatrixCells(TArray<FDMXCell> Cells) { return default; }
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extend type conversions to handle Entity Reference structs</summary>
[CppInclude("Library/DMXEntityReference.h")]
public partial class UDMXEntityReferenceConversions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Conv_ControllerRefToObj</summary>
	public static UDMXEntityController Conv_ControllerRefToObj(FDMXEntityControllerRef InControllerRef) { return default; }
	///<summary>Conv_FixtureTypeRefToObj</summary>
	public static UDMXEntityFixtureType Conv_FixtureTypeRefToObj(FDMXEntityFixtureTypeRef InFixtureTypeRef) { return default; }
	///<summary>Conv_FixturePatchRefToObj</summary>
	public static UDMXEntityFixturePatch Conv_FixturePatchRefToObj(FDMXEntityFixturePatchRef InFixturePatchRef) { return default; }
	///<summary>Conv_ControllerObjToRef</summary>
	public static FDMXEntityControllerRef Conv_ControllerObjToRef(UDMXEntityController InController) { return default; }
	///<summary>Conv_FixtureTypeObjToRef</summary>
	public static FDMXEntityFixtureTypeRef Conv_FixtureTypeObjToRef(UDMXEntityFixtureType InFixtureType) { return default; }
	///<summary>Conv_FixturePatchObjToRef</summary>
	public static FDMXEntityFixturePatchRef Conv_FixturePatchObjToRef(UDMXEntityFixturePatch InFixturePatch) { return default; }
}

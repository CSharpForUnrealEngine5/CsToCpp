#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityReference.h")]
///<summary>Extend type conversions to handle Entity Reference structs</summary>
public partial class UDMXEntityReferenceConversions : UBlueprintFunctionLibrary {
// DMXEntityReferenceConversions
	public static UDMXEntityController Conv_ControllerRefToObj(FDMXEntityControllerRef InControllerRef) { return default; }
	public static UDMXEntityFixtureType Conv_FixtureTypeRefToObj(FDMXEntityFixtureTypeRef InFixtureTypeRef) { return default; }
	public static UDMXEntityFixturePatch Conv_FixturePatchRefToObj(FDMXEntityFixturePatchRef InFixturePatchRef) { return default; }
	public static FDMXEntityControllerRef Conv_ControllerObjToRef(UDMXEntityController InController) { return default; }
	public static FDMXEntityFixtureTypeRef Conv_FixtureTypeObjToRef(UDMXEntityFixtureType InFixtureType) { return default; }
	public static FDMXEntityFixturePatchRef Conv_FixturePatchObjToRef(UDMXEntityFixturePatch InFixturePatch) { return default; }
}

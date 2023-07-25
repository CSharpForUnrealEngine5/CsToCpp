#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityReference.h")]
///<summary>Extend type conversions to handle Entity Reference structs</summary>
public partial class UDMXEntityReferenceConversions : UBlueprintFunctionLibrary {
// DMXEntityReferenceConversions
	public UObject Conv_ControllerRefToObj(FDMXEntityControllerRef InControllerRef) { return default; }
	public UObject Conv_FixtureTypeRefToObj(FDMXEntityFixtureTypeRef InFixtureTypeRef) { return default; }
	public UObject Conv_FixturePatchRefToObj(FDMXEntityFixturePatchRef InFixturePatchRef) { return default; }
	public FDMXEntityControllerRef Conv_ControllerObjToRef(UObject InController) { return default; }
	public FDMXEntityFixtureTypeRef Conv_FixtureTypeObjToRef(UObject InFixtureType) { return default; }
	public FDMXEntityFixturePatchRef Conv_FixturePatchObjToRef(UObject InFixturePatch) { return default; }
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An Array of Fixture Patches that supports a transaction history resp. undo / redo</summary>
[CppInclude("DMXFixturePatchSharedDataSelection.h")]
public partial class UDMXFixturePatchSharedDataSelection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Selected Fixture Patches</summary>
	public TArray<TWeakObjectPtr<UDMXEntityFixturePatch>> SelectedFixturePatches;
	///<summary>Selected Universe</summary>
	public int SelectedUniverse;
}

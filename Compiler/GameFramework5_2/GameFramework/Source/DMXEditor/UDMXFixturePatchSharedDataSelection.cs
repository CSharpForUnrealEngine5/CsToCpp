#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixturePatchSharedDataSelection.h")]
///<summary>An Array of Fixture Patches that supports a transaction history resp. undo / redo</summary>
public partial class UDMXFixturePatchSharedDataSelection : UObject {
// DMXFixturePatchSharedDataSelection
	public TArray<TWeakObjectPtr<UDMXEntityFixturePatch>> SelectedFixturePatches;
	public int SelectedUniverse;
}

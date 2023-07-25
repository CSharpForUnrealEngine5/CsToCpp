#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureTypeSharedDataSelection.h")]
///<summary>An Array of Fixture Types that supports a transaction history resp. undo / redo</summary>
public partial class UDMXFixtureTypeSharedDataSelection : UObject {
// DMXFixtureTypeSharedDataSelection
	public TArray<TWeakObjectPtr<UDMXEntityFixtureType>> SelectedFixtureTypes;
	public TArray<int> SelectedModeIndices;
	public TArray<int> SelectedFunctionIndices;
	public bool bFixtureMatrixSelected;
}

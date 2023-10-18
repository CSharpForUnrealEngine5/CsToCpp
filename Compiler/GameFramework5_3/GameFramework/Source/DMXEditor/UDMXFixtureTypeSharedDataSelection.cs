namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An Array of Fixture Types that supports a transaction history resp. undo / redo</summary>
[CppInclude("DMXFixtureTypeSharedDataSelection.h")]
public partial class UDMXFixtureTypeSharedDataSelection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The Fixture types being edited</summary>
	public TArray<TWeakObjectPtr<UDMXEntityFixtureType>> SelectedFixtureTypes;
	///<summary>The Mode indices in the Selected Fixture Types currently being selected</summary>
	public TArray<int> SelectedModeIndices;
	///<summary>The Function indices in the Selected Fixture Types currently being selected</summary>
	public TArray<int> SelectedFunctionIndices;
	///<summary>If true the Fixture Matrices in the currently seleccted Modes are selected</summary>
	public bool bFixtureMatrixSelected;
}

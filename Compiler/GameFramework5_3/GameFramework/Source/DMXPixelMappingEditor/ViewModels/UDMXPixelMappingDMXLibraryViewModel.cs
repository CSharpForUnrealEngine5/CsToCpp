namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Model for the DMX Library View</summary>
[CppInclude("ViewModels/DMXPixelMappingDMXLibraryViewModel.h")]
public partial class UDMXPixelMappingDMXLibraryViewModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The DMX library of this view</summary>
	public UDMXLibrary DMXLibrary;
	///<summary>The fixture group component that this model uses</summary>
	public TWeakObjectPtr<UDMXPixelMappingFixtureGroupComponent> WeakFixtureGroupComponent;
	///<summary>Default fixture patch list descriptor</summary>
	public FDMXReadOnlyFixturePatchListDescriptor FixturePatchListDescriptor;
}

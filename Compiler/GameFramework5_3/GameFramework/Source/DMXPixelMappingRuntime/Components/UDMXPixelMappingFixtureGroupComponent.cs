namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container component for Fixture Items</summary>
[CppInclude("Components/DMXPixelMappingFixtureGroupComponent.h")]
public partial class UDMXPixelMappingFixtureGroupComponent : UDMXPixelMappingOutputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>DMXLibrary</summary>
	public UDMXLibrary DMXLibrary;
	///<summary>Layout script for the children of this component (hidden in customizations and displayed in its own panel).</summary>
	public UDMXPixelMappingLayoutScript LayoutScript;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container component for Fixture Items</summary>
[CppInclude("Components/DMXPixelMappingFixtureGroupComponent.h")]
public partial class UDMXPixelMappingFixtureGroupComponent : UDMXPixelMappingOutputComponent {
	///<summary>DMXLibrary</summary>
	public UDMXLibrary DMXLibrary;
	///<summary>Layout script for the children of this component (hidden in customizations and displayed in its own panel).</summary>
	public UDMXPixelMappingLayoutScript LayoutScript;
}

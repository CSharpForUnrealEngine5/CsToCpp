#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters to construct a Fixture Type.</summary>
[CppInclude("Library/DMXEntityFixtureType.h")]
public partial struct FDMXEntityFixtureTypeConstructionParams {
	public UDMXLibrary ParentDMXLibrary;
	public FDMXFixtureCategory DMXCategory;
	public TArray<FDMXFixtureMode> Modes;
}

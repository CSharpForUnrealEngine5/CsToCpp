#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixtureType.h")]
///<summary>Parameters to construct a Fixture Type.</summary>
public partial struct FDMXEntityFixtureTypeConstructionParams {
// DMXEntityFixtureTypeConstructionParams
	public UDMXLibrary ParentDMXLibrary;
	public FDMXFixtureCategory DMXCategory;
	public TArray<FDMXFixtureMode> Modes;
}

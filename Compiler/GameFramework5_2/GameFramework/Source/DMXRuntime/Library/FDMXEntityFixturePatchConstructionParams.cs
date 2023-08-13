namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters to construct a Fixture Patch.</summary>
[CppInclude("Library/DMXEntityFixturePatch.h")]
public partial struct FDMXEntityFixturePatchConstructionParams {
	public FDMXEntityFixtureTypeRef FixtureTypeRef;
	public int ActiveMode;
	public int UniverseID;
	public int StartingAddress;
}

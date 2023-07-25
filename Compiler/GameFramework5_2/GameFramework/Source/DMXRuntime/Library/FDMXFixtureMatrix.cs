#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityFixtureType.h")]
public partial struct FDMXFixtureMatrix {
// DMXFixtureMatrix
	public TArray<FDMXFixtureCellAttribute> CellAttributes;
	public int FirstCellChannel;
	public int XCells;
	public int YCells;
	public EDMXPixelMappingDistribution PixelMappingDistribution;
}

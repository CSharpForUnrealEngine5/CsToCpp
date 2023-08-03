#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Matrix pixel component</summary>
[CppInclude("Components/DMXPixelMappingMatrixCellComponent.h")]
public partial class UDMXPixelMappingMatrixCellComponent : UDMXPixelMappingOutputDMXComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CellID</summary>
	public int CellID;
	///<summary>FixturePatchMatrixRef_DEPRECATED</summary>
	public FDMXEntityFixturePatchRef FixturePatchMatrixRef_DEPRECATED;
	///<summary>CellCoordinate</summary>
	public FIntPoint CellCoordinate;
}

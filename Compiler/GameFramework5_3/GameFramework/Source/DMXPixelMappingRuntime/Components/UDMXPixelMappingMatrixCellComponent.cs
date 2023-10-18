namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Matrix pixel component</summary>
[CppInclude("Components/DMXPixelMappingMatrixCellComponent.h")]
public partial class UDMXPixelMappingMatrixCellComponent : UDMXPixelMappingOutputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CellID</summary>
	public int CellID;
	///<summary>CellCoordinate</summary>
	public FIntPoint CellCoordinate;
}

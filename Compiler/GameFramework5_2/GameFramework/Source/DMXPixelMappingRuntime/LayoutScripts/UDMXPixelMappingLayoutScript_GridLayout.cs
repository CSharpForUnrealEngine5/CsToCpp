#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Arranges the components in a grid</summary>
[CppInclude("LayoutScripts/DMXPixelMappingLayoutScript_GridLayout.h")]
public partial class UDMXPixelMappingLayoutScript_GridLayout : UDMXPixelMappingLayoutScript {
	///<summary>Num Columns of the grid</summary>
	public int Columns;
	///<summary>Num Rows of the grid</summary>
	public int Rows;
	///<summary>Padding of the cells</summary>
	public float Padding;
	///<summary>Horizontal text alignment</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>Vertical text alignment</summary>
	public EVerticalAlignment VerticalAlignment;
	///<summary>How cells are distributed, compared to their previous distribution</summary>
	public EDMXPixelMappingDistribution Distribution;
}

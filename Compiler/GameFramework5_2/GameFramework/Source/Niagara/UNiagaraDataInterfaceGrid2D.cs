#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRW.h")]
public partial class UNiagaraDataInterfaceGrid2D : UNiagaraDataInterfaceRWBase {
	///<summary>Option to clear the buffer prior to a stage where the iteration count does not match the grid resolution.  Useful for stages where one wants to do sparse writes</summary>
	public bool ClearBeforeNonIterationStage;
	///<summary>Number of cells in X</summary>
	public int NumCellsX;
	///<summary>Number of cells in Y</summary>
	public int NumCellsY;
	///<summary>Number of cells on the longest axis</summary>
	public int NumCellsMaxAxis;
	///<summary>Number of Attributes</summary>
	public int NumAttributes;
	///<summary>Set grid resolution according to longest axis</summary>
	public bool SetGridFromMaxAxis;
	///<summary>World size of the grid</summary>
	public FVector2D WorldBBoxSize;
}

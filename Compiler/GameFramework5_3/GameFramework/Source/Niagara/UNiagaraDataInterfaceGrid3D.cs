namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRW.h")]
public partial class UNiagaraDataInterfaceGrid3D : UNiagaraDataInterfaceRWBase {
	public static UClass StaticClass() {return default;}
	///<summary>Option to clear the buffer prior to a stage where the iteration count does not match the grid resolution.  Useful for stages where one wants to do sparse writes</summary>
	public bool ClearBeforeNonIterationStage;
	///<summary>Number of cells</summary>
	public FIntVector NumCells;
	///<summary>World space size of a cell</summary>
	public float CellSize;
	///<summary>Number of cells on the longest axis</summary>
	public int NumCellsMaxAxis;
	///<summary>Method for setting the grid resolution</summary>
	public ESetResolutionMethod SetResolutionMethod;
	///<summary>World size of the grid</summary>
	public FVector WorldBBoxSize;
}

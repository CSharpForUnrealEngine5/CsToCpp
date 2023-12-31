namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface for the strand base</summary>
[CppInclude("Niagara/NiagaraDataInterfaceVelocityGrid.h")]
public partial class UNiagaraDataInterfaceVelocityGrid : UNiagaraDataInterfaceRWBase {
	public static UClass StaticClass() {return default;}
	///<summary>Grid size along the X axis.</summary>
	public FIntVector GridSize;
}

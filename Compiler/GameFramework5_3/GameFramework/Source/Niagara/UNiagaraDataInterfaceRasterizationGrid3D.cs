namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRasterizationGrid3D.h")]
public partial class UNiagaraDataInterfaceRasterizationGrid3D : UNiagaraDataInterfaceGrid3D {
	public static UClass StaticClass() {return default;}
	///<summary>Number of attributes stored on the grid</summary>
	public int NumAttributes;
	///<summary>Precision</summary>
	public float Precision;
	///<summary>ResetValue</summary>
	public int ResetValue;
}

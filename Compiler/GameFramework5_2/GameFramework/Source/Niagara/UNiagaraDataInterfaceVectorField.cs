#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceVectorField.h")]
public partial class UNiagaraDataInterfaceVectorField : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Vector field to sample from.</summary>
	public UVectorField Field;
	///<summary>bTileX</summary>
	public bool bTileX;
	///<summary>bTileY</summary>
	public bool bTileY;
	///<summary>bTileZ</summary>
	public bool bTileZ;
}

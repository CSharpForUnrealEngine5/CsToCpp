#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of curl noise LUT.</summary>
[CppInclude("NiagaraDataInterfaceCurlNoise.h")]
public partial class UNiagaraDataInterfaceCurlNoise : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Seed</summary>
	public uint Seed;
}

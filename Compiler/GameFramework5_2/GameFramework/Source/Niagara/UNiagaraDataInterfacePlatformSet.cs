#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing querying of the current platform set.</summary>
[CppInclude("NiagaraDataInterfacePlatformSet.h")]
public partial class UNiagaraDataInterfacePlatformSet : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Platforms</summary>
	public FNiagaraPlatformSet Platforms;
}

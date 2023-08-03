#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceArrayFloat.h")]
public partial class UNiagaraDataInterfaceArrayQuat : UNiagaraDataInterfaceArray {
	public static UClass StaticClass() {return default;}
	///<summary>QuatData</summary>
	public TArray<FQuat> QuatData;
	///<summary>InternalQuatData</summary>
	public TArray<FQuat4f> InternalQuatData;
}

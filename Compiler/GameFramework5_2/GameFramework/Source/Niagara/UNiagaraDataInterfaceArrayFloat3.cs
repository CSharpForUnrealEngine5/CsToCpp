#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceArrayFloat.h")]
public partial class UNiagaraDataInterfaceArrayFloat3 : UNiagaraDataInterfaceArray {
	public static UClass StaticClass() {return default;}
	///<summary>FloatData</summary>
	public TArray<FVector> FloatData;
	///<summary>InternalFloatData</summary>
	public TArray<FVector3f> InternalFloatData;
}

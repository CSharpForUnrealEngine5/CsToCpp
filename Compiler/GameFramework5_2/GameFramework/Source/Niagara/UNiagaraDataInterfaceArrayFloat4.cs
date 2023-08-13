namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceArrayFloat.h")]
public partial class UNiagaraDataInterfaceArrayFloat4 : UNiagaraDataInterfaceArray {
	public static UClass StaticClass() {return default;}
	///<summary>FloatData</summary>
	public TArray<FVector4> FloatData;
	///<summary>InternalFloatData</summary>
	public TArray<FVector4f> InternalFloatData;
}

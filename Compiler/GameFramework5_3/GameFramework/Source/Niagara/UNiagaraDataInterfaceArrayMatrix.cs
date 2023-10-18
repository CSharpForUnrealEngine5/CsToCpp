namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceArrayFloat.h")]
public partial class UNiagaraDataInterfaceArrayMatrix : UNiagaraDataInterfaceArray {
	public static UClass StaticClass() {return default;}
	///<summary>MatrixData</summary>
	public TArray<FMatrix> MatrixData;
	///<summary>InternalMatrixData</summary>
	public TArray<FMatrix44f> InternalMatrixData;
}

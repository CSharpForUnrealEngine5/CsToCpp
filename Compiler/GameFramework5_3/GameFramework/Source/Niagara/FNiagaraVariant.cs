namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraVariant.h")]
public partial struct FNiagaraVariant {
	public UObject Object;
	public UNiagaraDataInterface DataInterface;
	public TArray<byte> Bytes;
	public ENiagaraVariantMode CurrentMode;
}

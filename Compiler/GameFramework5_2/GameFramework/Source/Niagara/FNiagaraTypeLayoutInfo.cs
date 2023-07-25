#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
///<summary>Information about how this type should be laid out in an FNiagaraDataSet</summary>
public partial struct FNiagaraTypeLayoutInfo {
// NiagaraTypeLayoutInfo
	public TArray<uint> FloatComponentByteOffsets;
	public TArray<uint> FloatComponentRegisterOffsets;
	public TArray<uint> Int32ComponentByteOffsets;
	public TArray<uint> Int32ComponentRegisterOffsets;
	public TArray<uint> HalfComponentByteOffsets;
	public TArray<uint> HalfComponentRegisterOffsets;
}

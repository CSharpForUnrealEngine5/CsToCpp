#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about how this type should be laid out in an FNiagaraDataSet</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraTypeLayoutInfo {
	public TArray<uint> FloatComponentByteOffsets;
	public TArray<uint> FloatComponentRegisterOffsets;
	public TArray<uint> Int32ComponentByteOffsets;
	public TArray<uint> Int32ComponentRegisterOffsets;
	public TArray<uint> HalfComponentByteOffsets;
	public TArray<uint> HalfComponentRegisterOffsets;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about how this type should be laid out in an FNiagaraDataSet</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraTypeLayoutInfo {
	public ushort NumFloatComponents;
	public ushort NumInt32Components;
	public ushort NumHalfComponents;
	public TArray<uint> ComponentsOffsets;
}

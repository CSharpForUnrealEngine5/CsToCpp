#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataSetCompiledData.h")]
///<summary>Helper class defining the layout and location of an FNiagaraVariable in an FNiagaraDataBuffer-></summary>
public partial struct FNiagaraVariableLayoutInfo {
// NiagaraVariableLayoutInfo
	public uint FloatComponentStart;
	public uint Int32ComponentStart;
	public uint HalfComponentStart;
	public FNiagaraTypeLayoutInfo LayoutInfo;
}

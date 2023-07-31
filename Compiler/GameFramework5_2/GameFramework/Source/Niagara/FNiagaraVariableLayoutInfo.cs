#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class defining the layout and location of an FNiagaraVariable in an FNiagaraDataBuffer-&gt;</summary>
[CppInclude("NiagaraDataSetCompiledData.h")]
public partial struct FNiagaraVariableLayoutInfo {
	public uint FloatComponentStart;
	public uint Int32ComponentStart;
	public uint HalfComponentStart;
	public FNiagaraTypeLayoutInfo LayoutInfo;
}

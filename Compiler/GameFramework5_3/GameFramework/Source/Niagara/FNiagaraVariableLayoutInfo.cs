namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class defining the layout and location of an FNiagaraVariable in an FNiagaraDataBuffer-&gt;</summary>
[CppInclude("NiagaraDataSetCompiledData.h")]
public partial struct FNiagaraVariableLayoutInfo {
	public ushort FloatComponentStart;
	public ushort Int32ComponentStart;
	public ushort HalfComponentStart;
	public FNiagaraTypeLayoutInfo LayoutInfo;
}

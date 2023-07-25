#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheDataBuffersLayout {
// NiagaraSimCacheDataBuffersLayout
	public string LayoutName;
	public ENiagaraSimTarget SimTarget;
	public TArray<FNiagaraSimCacheVariable> Variables;
	public ushort FloatCount;
	public ushort HalfCount;
	public ushort Int32Count;
	public bool bLocalSpace;
	public bool bAllowInterpolation;
	public bool bAllowVelocityExtrapolation;
	public TArray<string> RebaseVariableNames;
	public TArray<string> InterpVariableNames;
	public ushort ComponentVelocity;
}

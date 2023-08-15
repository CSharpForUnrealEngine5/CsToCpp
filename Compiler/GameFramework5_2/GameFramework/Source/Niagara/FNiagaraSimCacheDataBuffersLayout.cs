namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheDataBuffersLayout {
	public FName LayoutName;
	public ENiagaraSimTarget SimTarget;
	public TArray<FNiagaraSimCacheVariable> Variables;
	public ushort FloatCount;
	public ushort HalfCount;
	public ushort Int32Count;
	public bool bLocalSpace;
	public bool bAllowInterpolation;
	public bool bAllowVelocityExtrapolation;
	public TArray<FName> RebaseVariableNames;
	public TArray<FName> InterpVariableNames;
	public ushort ComponentVelocity;
}

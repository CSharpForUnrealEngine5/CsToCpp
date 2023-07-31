#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>Enum used to track stage that GPU compute proxies will execute in.</summary>
[CppEnumInNamespace]
public enum ENiagaraGpuComputeTickStage {
	PreInitViews=0,
	PostInitViews=1,
	PostOpaqueRender=2,
	Max=3,
	First=-1,
	Last=-1,
}

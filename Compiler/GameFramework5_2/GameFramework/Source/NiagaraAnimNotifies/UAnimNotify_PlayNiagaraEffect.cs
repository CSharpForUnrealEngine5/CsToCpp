#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNotify_PlayNiagaraEffect.h")]
public partial class UAnimNotify_PlayNiagaraEffect : UAnimNotify {
// AnimNotify_PlayNiagaraEffect
	public UNiagaraSystem Template;
	public FVector LocationOffset;
	public FRotator RotationOffset;
	public FVector Scale;
	public bool bAbsoluteScale;
	public  UFXSystemComponent GetSpawnedEffect() { return default; }
	public bool Attached;
	public string SocketName;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioParameterComponent.h")]
///<summary>UAudioParameterComponent - Can be used to set/store audio parameters and automatically dispatch them (through ActorSoundParameterInterface)</summary>
public partial class UAudioParameterComponent : UActorComponent {
// AudioParameterComponent
	public TArray<FAudioParameter> GetParameters() { return default; }
	public TArray<TWeakObjectPtr<UAudioComponent>> ActiveComponents;
	public TArray<FAudioParameter> Parameters;
}

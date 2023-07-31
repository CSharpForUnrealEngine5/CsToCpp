#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioParameterComponent - Can be used to set/store audio parameters and automatically dispatch them (through ActorSoundParameterInterface)</summary>
[CppInclude("AudioParameterComponent.h")]
public partial class UAudioParameterComponent : UActorComponent {
	///<summary>GetParameters</summary>
	public  TArray<FAudioParameter> GetParameters() { return default; }
	///<summary>ActiveComponents</summary>
	public TArray<TWeakObjectPtr<UAudioComponent>> ActiveComponents;
	///<summary>Parameters</summary>
	public TArray<FAudioParameter> Parameters;
}

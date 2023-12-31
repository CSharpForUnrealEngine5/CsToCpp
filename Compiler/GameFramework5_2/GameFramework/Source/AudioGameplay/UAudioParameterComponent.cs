namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioParameterComponent - Can be used to set/store audio parameters and automatically dispatch them (through ActorSoundParameterInterface)</summary>
[CppInclude("AudioParameterComponent.h")]
public partial class UAudioParameterComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GetParameters</summary>
	public TArray<FAudioParameter> GetParameters() { return default; }
	///<summary>ActiveComponents</summary>
	public TArray<TWeakObjectPtr<UAudioComponent>> ActiveComponents;
	///<summary>Parameters</summary>
	public TArray<FAudioParameter> Parameters;
}

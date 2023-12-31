namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Audio/ActorSoundParameterInterface.h")]
public partial class UActorSoundParameterInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Overrides logic for gathering AudioParameters to set by default when an AudioComponent/ActiveSound plays with a given actor as its Owner.</summary>
	public void GetActorSoundParams(TArray<FAudioParameter> Params) {}
}

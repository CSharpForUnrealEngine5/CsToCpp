#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionStimuliSourceComponent.h")]
///<summary>Gives owning actor a way to auto-register as perception system's sense stimuli source</summary>
public partial class UAIPerceptionStimuliSourceComponent : UActorComponent {
// AIPerceptionStimuliSourceComponent
	public bool bAutoRegisterAsSource;
	public TArray<UClass> RegisterAsSourceForSenses;
	public void RegisterWithPerceptionSystem() {}
	public void RegisterForSense(UClass SenseClass) {}
	public void UnregisterFromPerceptionSystem() {}
	public void UnregisterFromSense(UClass SenseClass) {}
}

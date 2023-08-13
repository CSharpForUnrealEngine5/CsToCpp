namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gives owning actor a way to auto-register as perception system&#39;s sense stimuli source</summary>
[CppInclude("Perception/AIPerceptionStimuliSourceComponent.h")]
public partial class UAIPerceptionStimuliSourceComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>bAutoRegisterAsSource</summary>
	public bool bAutoRegisterAsSource;
	///<summary>RegisterAsSourceForSenses</summary>
	public TArray<UClass> RegisterAsSourceForSenses;
	///<summary>Registers owning actor as source of stimuli for senses specified in RegisterAsSourceForSenses.</summary>
	public void RegisterWithPerceptionSystem() {}
	///<summary>Registers owning actor as source for specified sense class</summary>
	public void RegisterForSense(UClass SenseClass) {}
	///<summary>Unregister owning actor from being a source of sense stimuli</summary>
	public void UnregisterFromPerceptionSystem() {}
	///<summary>Unregisters owning actor from sources list of a specified sense class</summary>
	public void UnregisterFromSense(UClass SenseClass) {}
}

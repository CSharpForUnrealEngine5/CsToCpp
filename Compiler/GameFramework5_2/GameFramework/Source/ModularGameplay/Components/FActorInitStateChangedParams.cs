#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/GameFrameworkComponentDelegates.h")]
///<summary>Parameters struct for Init State change functions</summary>
public partial struct FActorInitStateChangedParams {
// ActorInitStateChangedParams
	public AActor OwningActor;
	public string FeatureName;
	public UObject Implementer;
	public FGameplayTag FeatureState;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters struct for Init State change functions</summary>
[CppInclude("Components/GameFrameworkComponentDelegates.h")]
public partial struct FActorInitStateChangedParams {
	public AActor OwningActor;
	public FName FeatureName;
	public UObject Implementer;
	public FGameplayTag FeatureState;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ApplicationLifecycleComponent.h")]
///<summary>Component to handle receiving notifications from the OS about application state (activated, suspended, termination, etc).</summary>
public partial class UApplicationLifecycleComponent : UActorComponent {
// ApplicationLifecycleComponent
	public void FApplicationLifetimeDelegate() {}
	public void FOnTemperatureChangeDelegate(ETemperatureSeverityType Severity) {}
	public void FOnLowPowerModeDelegate(bool bInLowPowerMode) {}
	public FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate;
	public FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate;
	public FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate;
	public FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate;
	public FApplicationLifetimeDelegate ApplicationWillTerminateDelegate;
	public FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate;
	public void FApplicationStartupArgumentsDelegate(TArray<string> StartupArguments) {}
	public FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate;
	public FOnTemperatureChangeDelegate OnTemperatureChangeDelegate;
	public FOnLowPowerModeDelegate OnLowPowerModeDelegate;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component to handle receiving notifications from the OS about application state (activated, suspended, termination, etc).</summary>
[CppInclude("Components/ApplicationLifecycleComponent.h")]
public partial class UApplicationLifecycleComponent : UActorComponent {
	///<summary>FApplicationLifetimeDelegate</summary>
	public  void FApplicationLifetimeDelegate() {}
	///<summary>FOnTemperatureChangeDelegate</summary>
	public  void FOnTemperatureChangeDelegate(ETemperatureSeverityType Severity) {}
	///<summary>FOnLowPowerModeDelegate</summary>
	public  void FOnLowPowerModeDelegate(bool bInLowPowerMode) {}
	///<summary>This is called when the application is about to be deactivated (e.g., due to a phone call or SMS or the sleep button).</summary>
	public FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate;
	///<summary>Called when the application has been reactivated (reverse any processing done in the Deactivate delegate)</summary>
	public FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate;
	///<summary>This is called when the application is being backgrounded (e.g., due to switching</summary>
	public FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate;
	///<summary>Called when the application is returning to the foreground (reverse any processing done in the EnterBackground delegate)</summary>
	public FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate;
	///<summary>This *may* be called when the application is getting terminated by the OS.</summary>
	public FApplicationLifetimeDelegate ApplicationWillTerminateDelegate;
	///<summary>Called when the OS is running low on resources and asks the application to free up any cached resources, drop graphics quality etc.</summary>
	public FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate;
	///<summary>FApplicationStartupArgumentsDelegate</summary>
	public  void FApplicationStartupArgumentsDelegate(TArray<string> StartupArguments) {}
	///<summary>Called with arguments passed to the application on statup, perhaps meta data passed on by another application which launched this one.</summary>
	public FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate;
	///<summary>Called when temperature level has changed, and receives the severity</summary>
	public FOnTemperatureChangeDelegate OnTemperatureChangeDelegate;
	///<summary>Called when we are in low power mode</summary>
	public FOnLowPowerModeDelegate OnLowPowerModeDelegate;
}

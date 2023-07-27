#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
///<summary>UObject based class for handling mobile events. Having this object as an option gives the app lifetime access to these global delegates. The component UApplicationLifecycleComponent is destroyed at level loads</summary>
public partial class UPlatformGameInstance : UGameInstance {
// PlatformGameInstance
	public  void FPlatformDelegate() {}
	public  void FPlatformStartupArgumentsDelegate(TArray<string> StartupArguments) {}
	public  void FPlatformRegisteredForRemoteNotificationsDelegate(TArray<byte> inArray) {}
	public  void FPlatformRegisteredForUserNotificationsDelegate(int inInt) {}
	public  void FPlatformFailedToRegisterForRemoteNotificationsDelegate(string inString) {}
	public  void FPlatformReceivedRemoteNotificationDelegate(string inString,EApplicationState inAppState) {}
	public  void FPlatformReceivedLocalNotificationDelegate(string inString,int inInt,EApplicationState inAppState) {}
	public  void FPlatformScreenOrientationChangedDelegate(EScreenOrientation inScreenOrientation) {}
	public FPlatformDelegate ApplicationWillDeactivateDelegate;
	public FPlatformDelegate ApplicationHasReactivatedDelegate;
	public FPlatformDelegate ApplicationWillEnterBackgroundDelegate;
	public FPlatformDelegate ApplicationHasEnteredForegroundDelegate;
	public FPlatformDelegate ApplicationWillTerminateDelegate;
	public FPlatformDelegate ApplicationShouldUnloadResourcesDelegate;
	public FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate;
	public FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate;
	public FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate;
	public FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate;
	public FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate;
	public FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate;
	public FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate;
}

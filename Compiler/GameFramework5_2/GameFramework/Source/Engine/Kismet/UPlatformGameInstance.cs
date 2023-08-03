#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject based class for handling mobile events. Having this object as an option gives the app lifetime access to these global delegates. The component UApplicationLifecycleComponent is destroyed at level loads</summary>
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
public partial class UPlatformGameInstance : UGameInstance {
	public static UClass StaticClass() {return default;}
	///<summary>FPlatformDelegate</summary>
	public  void FPlatformDelegate() {}
	///<summary>FPlatformStartupArgumentsDelegate</summary>
	public  void FPlatformStartupArgumentsDelegate(TArray<string> StartupArguments) {}
	///<summary>FPlatformRegisteredForRemoteNotificationsDelegate</summary>
	public  void FPlatformRegisteredForRemoteNotificationsDelegate(TArray<byte> inArray) {}
	///<summary>FPlatformRegisteredForUserNotificationsDelegate</summary>
	public  void FPlatformRegisteredForUserNotificationsDelegate(int inInt) {}
	///<summary>FPlatformFailedToRegisterForRemoteNotificationsDelegate</summary>
	public  void FPlatformFailedToRegisterForRemoteNotificationsDelegate(string inString) {}
	///<summary>FPlatformReceivedRemoteNotificationDelegate</summary>
	public  void FPlatformReceivedRemoteNotificationDelegate(string inString,EApplicationState inAppState) {}
	///<summary>FPlatformReceivedLocalNotificationDelegate</summary>
	public  void FPlatformReceivedLocalNotificationDelegate(string inString,int inInt,EApplicationState inAppState) {}
	///<summary>FPlatformScreenOrientationChangedDelegate</summary>
	public  void FPlatformScreenOrientationChangedDelegate(EScreenOrientation inScreenOrientation) {}
	///<summary>This is called when the application is about to be deactivated (e.g., due to a phone call or SMS or the sleep button).</summary>
	public FPlatformDelegate ApplicationWillDeactivateDelegate;
	///<summary>Called when the application has been reactivated (reverse any processing done in the Deactivate delegate)</summary>
	public FPlatformDelegate ApplicationHasReactivatedDelegate;
	///<summary>This is called when the application is being backgrounded (e.g., due to switching</summary>
	public FPlatformDelegate ApplicationWillEnterBackgroundDelegate;
	///<summary>Called when the application is returning to the foreground (reverse any processing done in the EnterBackground delegate)</summary>
	public FPlatformDelegate ApplicationHasEnteredForegroundDelegate;
	///<summary>This *may* be called when the application is getting terminated by the OS.</summary>
	public FPlatformDelegate ApplicationWillTerminateDelegate;
	///<summary>Called when the OS is running low on resources and asks the application to free up any cached resources, drop graphics quality etc.</summary>
	public FPlatformDelegate ApplicationShouldUnloadResourcesDelegate;
	///<summary>Called with arguments passed to the application on statup, perhaps meta data passed on by another application which launched this one.</summary>
	public FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate;
	///<summary>called when the user grants permission to register for remote notifications</summary>
	public FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate;
	///<summary>called when the user grants permission to register for notifications</summary>
	public FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate;
	///<summary>called when the application fails to register for remote notifications</summary>
	public FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate;
	///<summary>called when the application receives a remote notification</summary>
	public FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate;
	///<summary>called when the application receives a local notification</summary>
	public FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate;
	///<summary>called when the application receives a screen orientation change notification</summary>
	public FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate;
}

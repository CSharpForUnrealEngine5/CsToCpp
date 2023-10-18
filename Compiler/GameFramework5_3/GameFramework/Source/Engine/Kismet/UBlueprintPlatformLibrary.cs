namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
public partial class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Clear all pending local notifications. Typically this will be done before scheduling new notifications when going into the background</summary>
	public static void ClearAllLocalNotifications() {}
	///<summary>Schedule a local notification at a specific time, inLocalTime specifies the current local time or if UTC time should be used</summary>
	public static int ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,FText Title,FText Body,FText Action,string ActivationEvent) { return default; }
	///<summary>Schedule a local notification to fire inSecondsFromNow from now</summary>
	public static int ScheduleLocalNotificationFromNow(int inSecondsFromNow,FText Title,FText Body,FText Action,string ActivationEvent) { return default; }
	///<summary>Schedule a local notification badge at a specific time, inLocalTime specifies the current local time or if UTC time should be used</summary>
	public static int ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime,bool LocalTime,string ActivationEvent) { return default; }
	///<summary>Schedule a local notification badge to fire inSecondsFromNow from now</summary>
	public static void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow,string ActivationEvent) {}
	///<summary>Cancel a local notification given the ActivationEvent</summary>
	public static void CancelLocalNotification(string ActivationEvent) {}
	///<summary>Cancel a local notification given the ActivationEvent</summary>
	public static void CancelLocalNotificationById(int NotificationId) {}
	///<summary>Get the local notification that was used to launch the app</summary>
	public static void GetLaunchNotification(bool NotificationLaunchedApp,string ActivationEvent,int FireDate) {}
	///<summary>Returns the current orientation of the device: will be either Portrait, LandscapeLeft, PortraitUpsideDown or LandscapeRight.</summary>
	public static EScreenOrientation GetDeviceOrientation() { return default; }
	///<summary>Returns the allowed orientation of the device. This is NOT the same as GetDeviceOrientation, which only returns Portrait, LandscapeLeft,</summary>
	public static EScreenOrientation GetAllowedDeviceOrientation() { return default; }
	///<summary>Set the allowed orientation of the device.</summary>
	public static void SetAllowedDeviceOrientation(EScreenOrientation NewAllowedDeviceOrientation) {}
}

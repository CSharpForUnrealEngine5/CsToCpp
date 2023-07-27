#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
public partial class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary {
// BlueprintPlatformLibrary
	public static void ClearAllLocalNotifications() {}
	public static int ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,string Title,string Body,string Action,string ActivationEvent) { return default; }
	public static int ScheduleLocalNotificationFromNow(int inSecondsFromNow,string Title,string Body,string Action,string ActivationEvent) { return default; }
	public static int ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime,bool LocalTime,string ActivationEvent) { return default; }
	public static void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow,string ActivationEvent) {}
	public static void CancelLocalNotification(string ActivationEvent) {}
	public static void CancelLocalNotificationById(int NotificationId) {}
	public static void GetLaunchNotification(bool NotificationLaunchedApp,string ActivationEvent,int FireDate) {}
	public static EScreenOrientation GetDeviceOrientation() { return default; }
	public static EScreenOrientation GetAllowedDeviceOrientation() { return default; }
	public static void SetAllowedDeviceOrientation(EScreenOrientation NewAllowedDeviceOrientation) {}
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/BlueprintPlatformLibrary.h")]
public partial class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary {
// BlueprintPlatformLibrary
	public void ClearAllLocalNotifications() {}
	public int ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,string Title,string Body,string Action,string ActivationEvent) { return default; }
	public int ScheduleLocalNotificationFromNow(int inSecondsFromNow,string Title,string Body,string Action,string ActivationEvent) { return default; }
	public int ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime,bool LocalTime,string ActivationEvent) { return default; }
	public void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow,string ActivationEvent) {}
	public void CancelLocalNotification(string ActivationEvent) {}
	public void CancelLocalNotificationById(int NotificationId) {}
	public void GetLaunchNotification(bool NotificationLaunchedApp,string ActivationEvent,int FireDate) {}
	public EScreenOrientation GetDeviceOrientation() { return default; }
	public EScreenOrientation GetAllowedDeviceOrientation() { return default; }
	public void SetAllowedDeviceOrientation(EScreenOrientation NewAllowedDeviceOrientation) {}
}

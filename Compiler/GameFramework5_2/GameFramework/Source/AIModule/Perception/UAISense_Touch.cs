#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Touch.h")]
public partial class UAISense_Touch : UAISense {
	///<summary>RegisteredEvents</summary>
	public TArray<FAITouchEvent> RegisteredEvents;
	///<summary>ReportTouchEvent</summary>
	public static void ReportTouchEvent(UObject WorldContextObject,AActor TouchReceiver,AActor OtherActor,FVector Location) {}
}

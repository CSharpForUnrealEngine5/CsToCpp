#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Touch.h")]
public partial class UAISense_Touch : UAISense {
// AISense_Touch
	public TArray<FAITouchEvent> RegisteredEvents;
	public static void ReportTouchEvent(UObject WorldContextObject,AActor TouchReceiver,AActor OtherActor,FVector Location) {}
}

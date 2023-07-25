#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Touch.h")]
public partial class UAISense_Touch : UAISense {
// AISense_Touch
	public TArray<FAITouchEvent> RegisteredEvents;
	public void ReportTouchEvent(UObject WorldContextObject,UObject TouchReceiver,UObject OtherActor,FVector Location) {}
}

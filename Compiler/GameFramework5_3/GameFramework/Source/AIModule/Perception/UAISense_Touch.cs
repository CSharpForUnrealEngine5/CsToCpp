namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Touch.h")]
public partial class UAISense_Touch : UAISense {
	public static UClass StaticClass() {return default;}
	///<summary>RegisteredEvents</summary>
	public TArray<FAITouchEvent> RegisteredEvents;
	///<summary>ReportTouchEvent</summary>
	public static void ReportTouchEvent(UObject WorldContextObject,AActor TouchReceiver,AActor OtherActor,FVector Location) {}
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set of utilities for dealing with Disturbance Annotation.</summary>
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotationBPLibrary.h")]
public partial class UZoneGraphDisturbanceAnnotationBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>* Triggers Danger event at specific location.</summary>
	public static void TriggerDanger(UObject WorldContextObject,AActor Instigator,FVector Position,float Radius,float Duration) {}
}

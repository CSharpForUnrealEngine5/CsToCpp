namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Hearing.h")]
public partial class UAISense_Hearing : UAISense {
	public static UClass StaticClass() {return default;}
	///<summary>NoiseEvents</summary>
	public TArray<FAINoiseEvent> NoiseEvents;
	///<summary>Defaults to 0 to have instant notification. Setting to &gt; 0 will result in delaying</summary>
	public float SpeedOfSoundSq;
	///<summary>Report a noise event.</summary>
	public static void ReportNoiseEvent(UObject WorldContextObject,FVector NoiseLocation,float Loudness/*=1.0f*/,AActor Instigator/*=nullptr*/,float MaxRange/*=0.0f*/,FName Tag/*=NAME_None*/) {}
}

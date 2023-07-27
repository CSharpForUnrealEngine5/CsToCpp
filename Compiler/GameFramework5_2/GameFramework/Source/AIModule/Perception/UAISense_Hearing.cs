#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Hearing.h")]
public partial class UAISense_Hearing : UAISense {
// AISense_Hearing
	public TArray<FAINoiseEvent> NoiseEvents;
	public float SpeedOfSoundSq;
	public static void ReportNoiseEvent(UObject WorldContextObject,FVector NoiseLocation,float Loudness/*=1.0f*/,AActor Instigator/*=nullptr*/,float MaxRange/*=0.0f*/,string Tag/*=NAME_None*/) {}
}

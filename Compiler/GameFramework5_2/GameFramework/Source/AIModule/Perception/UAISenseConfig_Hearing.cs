#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISenseConfig_Hearing.h")]
public partial class UAISenseConfig_Hearing : UAISenseConfig {
// AISenseConfig_Hearing
	public UClass Implementation;
	public float HearingRange;
	public float LoSHearingRange;
	public bool bUseLoSHearing;
	public FAISenseAffiliationFilter DetectionByAffiliation;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISenseConfig_Hearing.h")]
public partial class UAISenseConfig_Hearing : UAISenseConfig {
	///<summary>Implementation</summary>
	public UClass Implementation;
	///<summary>HearingRange</summary>
	public float HearingRange;
	///<summary>LoSHearingRange</summary>
	public float LoSHearingRange;
	///<summary>bUseLoSHearing</summary>
	public bool bUseLoSHearing;
	///<summary>DetectionByAffiliation</summary>
	public FAISenseAffiliationFilter DetectionByAffiliation;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputMappingQuery.h")]
///<summary>Mapping issues arising from a QueryMapKeyIn... call</summary>
public enum EMappingQueryIssue {
	NoIssue=0,
	ReservedByAction=1,
	HidesExistingMapping=2,
	HiddenByExistingMapping=4,
	CollisionWithMappingInSameContext=8,
	ForcesTypePromotion=16,
	ForcesTypeDemotion=32,
}

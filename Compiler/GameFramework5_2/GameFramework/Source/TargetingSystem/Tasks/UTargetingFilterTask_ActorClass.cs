#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UTargetingFilterTask_ActorClass</summary>
[CppInclude("Tasks/TargetingFilterTask_ActorClass.h")]
public partial class UTargetingFilterTask_ActorClass : UTargetingFilterTask_BasicFilterTemplate {
	///<summary>The set of required actor classes (must be one of these types to not be filtered out)</summary>
	public TArray<UClass> RequiredActorClassFilters;
	///<summary>The set of ignored actor classes (must NOT be one of these types)</summary>
	public TArray<UClass> IgnoredActorClassFilters;
}

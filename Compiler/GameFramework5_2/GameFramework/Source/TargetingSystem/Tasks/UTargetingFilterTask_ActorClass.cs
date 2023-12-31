namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@class UTargetingFilterTask_ActorClass</summary>
[CppInclude("Tasks/TargetingFilterTask_ActorClass.h")]
public partial class UTargetingFilterTask_ActorClass : UTargetingFilterTask_BasicFilterTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>The set of required actor classes (must be one of these types to not be filtered out)</summary>
	public TArray<UClass> RequiredActorClassFilters;
	///<summary>The set of ignored actor classes (must NOT be one of these types)</summary>
	public TArray<UClass> IgnoredActorClassFilters;
}

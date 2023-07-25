#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataSourceFiltering.h")]
///<summary>High-level filter structure used when filtering AActor instances to apply user filters to inside of a UWorld</summary>
public partial struct FActorClassFilter {
// ActorClassFilter
	public FSoftClassPath ActorClass;
	public bool bIncludeDerivedClasses;
}

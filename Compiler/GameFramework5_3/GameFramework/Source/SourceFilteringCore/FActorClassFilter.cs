namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>High-level filter structure used when filtering AActor instances to apply user filters to inside of a UWorld</summary>
[CppInclude("DataSourceFiltering.h")]
public partial struct FActorClassFilter {
	public FSoftClassPath ActorClass;
	public bool bIncludeDerivedClasses;
}

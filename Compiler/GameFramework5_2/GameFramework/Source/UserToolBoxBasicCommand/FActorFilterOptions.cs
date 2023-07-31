#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectActorByFilter.h")]
public partial struct FActorFilterOptions {
	public UBaseActorFilter Filter;
	public EActorFilterRule Rule;
	public EActorFilterSource Source;
	public bool ShowProperties;
}

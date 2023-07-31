#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectActorByFilter.h")]
public partial class USelectActorByFilter : UUTBBaseCommand {
	///<summary>ApplyToCurrentSelection</summary>
	public bool ApplyToCurrentSelection;
	///<summary>FilterStack</summary>
	public TArray<FActorFilterOptions> FilterStack;
}

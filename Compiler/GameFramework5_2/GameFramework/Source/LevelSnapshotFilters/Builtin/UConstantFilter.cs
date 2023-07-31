#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter which treats all actors the same.</summary>
[CppInclude("Builtin/ConstantFilter.h")]
public partial class UConstantFilter : ULevelSnapshotFilter {
	///<summary>IsActorValidResult</summary>
	public EFilterResult IsActorValidResult;
	///<summary>IsPropertyValidResult</summary>
	public EFilterResult IsPropertyValidResult;
	///<summary>IsDeletedActorValidResult</summary>
	public EFilterResult IsDeletedActorValidResult;
	///<summary>IsAddedActorValidResult</summary>
	public EFilterResult IsAddedActorValidResult;
}

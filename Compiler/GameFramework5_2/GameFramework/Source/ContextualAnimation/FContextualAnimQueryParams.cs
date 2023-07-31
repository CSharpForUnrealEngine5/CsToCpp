#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores the parameters passed into query function</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimQueryParams {
	public TWeakObjectPtr<AActor> Querier;
	public FTransform QueryTransform;
	public bool bComplexQuery;
	public bool bFindAnimStartTime;
}

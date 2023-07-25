#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
///<summary>Stores the parameters passed into query function</summary>
public partial struct FContextualAnimQueryParams {
// ContextualAnimQueryParams
	public TWeakObjectPtr<AActor> Querier;
	public FTransform QueryTransform;
	public bool bComplexQuery;
	public bool bFindAnimStartTime;
}

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

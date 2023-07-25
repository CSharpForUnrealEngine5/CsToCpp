#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
///<summary>Stores the result of a query function</summary>
public partial struct FContextualAnimQueryResult {
// ContextualAnimQueryResult
	public TWeakObjectPtr<UAnimMontage> Animation;
	public FTransform EntryTransform;
	public FTransform SyncTransform;
	public float AnimStartTime;
	public int AnimSetIdx;
}

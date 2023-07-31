#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores the result of a query function</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimQueryResult {
	public TWeakObjectPtr<UAnimMontage> Animation;
	public FTransform EntryTransform;
	public FTransform SyncTransform;
	public float AnimStartTime;
	public int AnimSetIdx;
}

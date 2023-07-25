#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPISubsystem.h")]
///<summary>Container for an Operation object pool, per operation type (class).</summary>
public partial struct FWebAPIPooledOperation {
// WebAPIPooledOperation
	public TSoftObjectPtr<UClass> ItemClass;
	public TArray<UWebAPIOperationObject> AvailableItems;
	public TArray<UWebAPIOperationObject> ItemsInUse;
}

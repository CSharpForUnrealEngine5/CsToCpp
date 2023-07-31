#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for an Operation object pool, per operation type (class).</summary>
[CppInclude("WebAPISubsystem.h")]
public partial struct FWebAPIPooledOperation {
	public TSoftObjectPtr<UClass> ItemClass;
	public TArray<UWebAPIOperationObject> AvailableItems;
	public TArray<UWebAPIOperationObject> ItemsInUse;
}

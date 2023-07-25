#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MicroTransactionBase.h")]
public partial class UMicroTransactionBase : UPlatformInterfaceBase {
// MicroTransactionBase
	public TArray<FPurchaseInfo> AvailableProducts;
	public string LastError;
	public string LastErrorSolution;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MicroTransactionBase.h")]
public partial class UMicroTransactionBase : UPlatformInterfaceBase {
	public static UClass StaticClass() {return default;}
	///<summary>The list of products available to purchase, filled out by the time a MTD_PurchaseQueryComplete is fired</summary>
	public TArray<FPurchaseInfo> AvailableProducts;
	///<summary>In case of errors, this will describe the most recent error</summary>
	public string LastError;
	///<summary>In case of errors, this will describe possible solutions (if there are any)</summary>
	public string LastErrorSolution;
}

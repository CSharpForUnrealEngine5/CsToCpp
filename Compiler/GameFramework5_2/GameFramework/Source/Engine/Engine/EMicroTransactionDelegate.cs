namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MicroTransactionBase.h")]
///<summary>All the types of delegate callbacks that a MicroTransaction subclass may receive from C++.</summary>
public enum EMicroTransactionDelegate {
	MTD_PurchaseQueryComplete=0,
	MTD_PurchaseComplete=1,
	MTD_MAX=2,
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class along with UPyTestVectorDelegate verify that 2 UObjects with the same delegate name/type, do not collide.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestStructDelegate : UObject {
	///<summary>FOnNameCollisionDelegate</summary>
	public  void FOnNameCollisionDelegate(FPyTestStruct PyStruct) {}
	///<summary>Called when a new item is selected in the combobox.</summary>
	public FOnNameCollisionDelegate OnNameCollisionTestDelegate;
}

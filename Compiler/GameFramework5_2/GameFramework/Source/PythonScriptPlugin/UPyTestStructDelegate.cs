#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>This class along with UPyTestVectorDelegate verify that 2 UObjects with the same delegate name/type, do not collide.</summary>
public partial class UPyTestStructDelegate : UObject {
// PyTestStructDelegate
	public void FOnNameCollisionDelegate(FPyTestStruct PyStruct) {}
	public FOnNameCollisionDelegate OnNameCollisionTestDelegate;
}

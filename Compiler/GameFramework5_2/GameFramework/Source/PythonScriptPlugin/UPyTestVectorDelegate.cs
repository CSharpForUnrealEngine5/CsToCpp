#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTest.h")]
///<summary>This class along with UPyTestStructDelegate verify that 2 UObjects with the same delegate name/type, do not collide.</summary>
public partial class UPyTestVectorDelegate : UObject {
// PyTestVectorDelegate
	public  void FOnNameCollisionDelegate(FVector2D Vec) {}
	public FOnNameCollisionDelegate OnNameCollisionTestDelegate;
}

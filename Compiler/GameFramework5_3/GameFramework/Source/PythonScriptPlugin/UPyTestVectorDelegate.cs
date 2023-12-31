namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class along with UPyTestStructDelegate verify that 2 UObjects with the same delegate name/type, do not collide.</summary>
[CppInclude("PyTest.h")]
public partial class UPyTestVectorDelegate : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FOnNameCollisionDelegate</summary>
	public void FOnNameCollisionDelegate(FVector2D Vec) {}
	///<summary>Called when a new item is selected in the combobox.</summary>
	public FOnNameCollisionDelegate OnNameCollisionTestDelegate;
}

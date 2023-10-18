namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimDataController.h")]
public partial class UAnimDataController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Model</summary>
	public TWeakObjectPtr<UAnimDataModel> Model;
	///<summary>ModelInterface</summary>
	public object /*ModelInterface*/ ModelInterface;
}

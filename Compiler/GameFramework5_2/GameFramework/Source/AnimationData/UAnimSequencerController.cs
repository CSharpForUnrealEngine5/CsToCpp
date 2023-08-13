namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimSequencerController.h")]
public partial class UAnimSequencerController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UObject (typed) pointer to Model</summary>
	public TWeakObjectPtr<UAnimationSequencerDataModel> Model;
	///<summary>ModelInterface</summary>
	public object /*ModelInterface*/ ModelInterface;
}

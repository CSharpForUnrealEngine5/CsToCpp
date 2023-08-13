namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargetFactory.h")]
public partial class UIKRetargetFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>SourceIKRig</summary>
	public TWeakObjectPtr<UIKRigDefinition> SourceIKRig;
}

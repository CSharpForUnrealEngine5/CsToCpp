namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigProcessor.h")]
public partial class UIKRigProcessor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>the stack of solvers to run in order</summary>
	public TArray<UIKRigSolver> Solvers;
}

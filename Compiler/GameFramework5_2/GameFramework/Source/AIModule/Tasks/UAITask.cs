namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/AITask.h")]
public partial class UAITask : UGameplayTask {
	public static UClass StaticClass() {return default;}
	///<summary>OwnerController</summary>
	public AAIController OwnerController;
}

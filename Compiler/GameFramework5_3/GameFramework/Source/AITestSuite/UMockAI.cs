namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockAI.h")]
public partial class UMockAI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Actor</summary>
	public AActor Actor;
	///<summary>BBComp</summary>
	public UBlackboardComponent BBComp;
	///<summary>BrainComp</summary>
	public UBrainComponent BrainComp;
	///<summary>PerceptionComp</summary>
	public UAIPerceptionComponent PerceptionComp;
}

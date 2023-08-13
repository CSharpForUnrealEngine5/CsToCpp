namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blackboard key type that holds a SmartObject claim handle</summary>
[CppInclude("BlackboardKeyType_SOClaimHandle.h")]
public partial class UBlackboardKeyType_SOClaimHandle : UBlackboardKeyType {
	public static UClass StaticClass() {return default;}
	///<summary>Handle</summary>
	public FSmartObjectClaimHandle Handle;
}

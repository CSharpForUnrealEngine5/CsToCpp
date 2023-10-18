namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Blackboard/BlackboardKeyType_Enum.h")]
public partial class UBlackboardKeyType_Enum : UBlackboardKeyType {
	public static UClass StaticClass() {return default;}
	///<summary>EnumType</summary>
	public UEnum EnumType;
	///<summary>name of enum defined in c++ code, will take priority over asset from EnumType property</summary>
	public string EnumName;
	///<summary>set when EnumName override is valid and active</summary>
	public bool bIsEnumNameValid;
}

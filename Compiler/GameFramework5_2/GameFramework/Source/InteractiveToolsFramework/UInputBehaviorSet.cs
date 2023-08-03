#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputBehaviorSet manages a set of UInputBehaviors, and provides various functions</summary>
[CppInclude("InputBehaviorSet.h")]
public partial class UInputBehaviorSet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Current set of known Behaviors</summary>
	public TArray<FBehaviorInfo> Behaviors;
}

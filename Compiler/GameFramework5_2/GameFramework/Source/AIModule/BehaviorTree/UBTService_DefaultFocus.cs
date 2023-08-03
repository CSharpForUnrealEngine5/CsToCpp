#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default Focus service node.</summary>
[CppInclude("BehaviorTree/Services/BTService_DefaultFocus.h")]
public partial class UBTService_DefaultFocus : UBTService_BlackboardBase {
	public static UClass StaticClass() {return default;}
	///<summary>not exposed to users on purpose. Here to make reusing focus-setting mechanics by derived classes possible</summary>
	public byte FocusPriority;
}

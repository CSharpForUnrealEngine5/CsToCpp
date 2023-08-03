#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for SmartObject tests.</summary>
[CppInclude("SmartObjectTestingActor.h")]
public partial class USmartObjectTest : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SmartObjectTestingActor</summary>
	public ASmartObjectTestingActor SmartObjectTestingActor;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for SmartObject tests.</summary>
[CppInclude("SmartObjectTestingActor.h")]
public partial class USmartObjectTest : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SmartObjectTestingActor</summary>
	public ASmartObjectTestingActor SmartObjectTestingActor;
}

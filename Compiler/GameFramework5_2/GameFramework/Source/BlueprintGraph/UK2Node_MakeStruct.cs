namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pure kismet node that creates a struct with specified values for each member</summary>
[CppInclude("K2Node_MakeStruct.h")]
public partial class UK2Node_MakeStruct : UK2Node_StructMemberSet {
	public static UClass StaticClass() {return default;}
	///<summary>Helper property to handle upgrades from an old system of displaying pins for</summary>
	public bool bMadeAfterOverridePinRemoval;
}

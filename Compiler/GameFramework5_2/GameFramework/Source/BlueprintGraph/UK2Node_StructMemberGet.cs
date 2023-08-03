#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pure kismet node that gets one or more member variables of a struct</summary>
[CppInclude("K2Node_StructMemberGet.h")]
public partial class UK2Node_StructMemberGet : UK2Node_StructOperation {
	public static UClass StaticClass() {return default;}
	///<summary>ShowPinForProperties</summary>
	public TArray<FOptionalPinFromProperty> ShowPinForProperties;
}

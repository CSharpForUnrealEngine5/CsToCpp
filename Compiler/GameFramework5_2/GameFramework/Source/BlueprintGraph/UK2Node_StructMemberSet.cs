namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Imperative kismet node that sets one or more member variables of a struct</summary>
[CppInclude("K2Node_StructMemberSet.h")]
public partial class UK2Node_StructMemberSet : UK2Node_StructOperation {
	public static UClass StaticClass() {return default;}
	///<summary>ShowPinForProperties</summary>
	public TArray<FOptionalPinFromProperty> ShowPinForProperties;
}

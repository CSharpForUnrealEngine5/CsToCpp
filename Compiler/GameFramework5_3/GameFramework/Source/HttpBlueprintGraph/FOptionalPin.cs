namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores pin connections to restore after a node rebuild.</summary>
[CppInclude("K2Node_MakeRequestHeader.h")]
public partial struct FOptionalPin {
	public FName PinName;
	public string PinDefaultValue;
	public FEdGraphPinReference LinkedTo;
}

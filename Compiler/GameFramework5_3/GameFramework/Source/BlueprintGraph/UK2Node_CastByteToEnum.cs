namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_CastByteToEnum.h")]
public partial class UK2Node_CastByteToEnum : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>Enum</summary>
	public UEnum Enum;
	///<summary>if true, the node returns always a valid value</summary>
	public bool bSafe;
}

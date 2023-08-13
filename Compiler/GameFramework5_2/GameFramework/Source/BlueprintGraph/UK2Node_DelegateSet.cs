namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_DelegateSet.h")]
public partial class UK2Node_DelegateSet : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>Delegate property name that this event is associated with on the target</summary>
	public string DelegatePropertyName;
	///<summary>Class that the delegate property is defined in</summary>
	public UClass DelegatePropertyClass;
}

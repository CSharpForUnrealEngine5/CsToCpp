namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Property Bind Action specifically for Bind Behaviour</summary>
[CppInclude("Action/Bind/RCPropertyBindAction.h")]
public partial class URCPropertyBindAction : URCPropertyAction {
	public static UClass StaticClass() {return default;}
	///<summary>The Controller that drives us</summary>
	public URCController Controller;
}

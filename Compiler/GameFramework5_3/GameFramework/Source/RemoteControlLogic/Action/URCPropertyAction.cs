namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Property Action which is set property value from the action to exposed property</summary>
[CppInclude("Action/RCPropertyAction.h")]
public partial class URCPropertyAction : URCAction {
	public static UClass StaticClass() {return default;}
	///<summary>Virtual Property Container</summary>
	public URCVirtualPropertySelfContainer PropertySelfContainer;
}

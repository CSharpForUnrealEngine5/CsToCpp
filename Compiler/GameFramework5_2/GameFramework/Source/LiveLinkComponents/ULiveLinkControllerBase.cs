namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkControllerBase.h")]
public partial class ULiveLinkControllerBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A component reference (customized) that allows the user to specify a component that this controller should control</summary>
	public FComponentReference ComponentPicker;
}

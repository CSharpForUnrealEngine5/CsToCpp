namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Controller. Container for Behaviours and Actions</summary>
[CppInclude("Controller/RCController.h")]
public partial class URCController : URCVirtualPropertyInContainer {
	public static UClass StaticClass() {return default;}
	///<summary>Set of the behaviours</summary>
	public TSet<URCBehaviour> Behaviours;
}

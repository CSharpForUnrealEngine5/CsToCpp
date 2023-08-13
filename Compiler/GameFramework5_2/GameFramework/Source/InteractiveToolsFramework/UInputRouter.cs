namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputRouter mediates between a higher-level input event source (eg like an FEdMode)</summary>
[CppInclude("InputRouter.h")]
public partial class UInputRouter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, then we post an Invalidation (ie redraw) request if any active InputBehavior responds to Hover events (default false)</summary>
	public bool bAutoInvalidateOnHover;
	///<summary>If true, then we post an Invalidation (ie redraw) request on every captured input event (default false)</summary>
	public bool bAutoInvalidateOnCapture;
	///<summary>ActiveInputBehaviors</summary>
	public UInputBehaviorSet ActiveInputBehaviors;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows tools to interact with the 3d preview viewport, which has a separate</summary>
[CppInclude("ContextObjects/UVToolContextObjects.h")]
public partial class UUVToolLivePreviewAPI : UUVToolContextObject {
	///<summary>World</summary>
	public TWeakObjectPtr<UWorld> World;
	///<summary>InputRouter</summary>
	public TWeakObjectPtr<UInputRouter> InputRouter;
}

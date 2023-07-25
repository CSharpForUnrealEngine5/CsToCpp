#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextObjects/UVToolContextObjects.h")]
///<summary>Allows tools to interact with the 3d preview viewport, which has a separate</summary>
public partial class UUVToolLivePreviewAPI : UUVToolContextObject {
// UVToolLivePreviewAPI
	public TWeakObjectPtr<UWorld> World;
	public TWeakObjectPtr<UInputRouter> InputRouter;
}

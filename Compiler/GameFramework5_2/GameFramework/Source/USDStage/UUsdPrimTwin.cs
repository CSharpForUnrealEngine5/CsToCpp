#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDPrimTwin.h")]
///<summary>The Unreal equivalent (twin) of a USD prim</summary>
public partial class UUsdPrimTwin : UObject {
// UsdPrimTwin
	public string PrimPath;
	public TWeakObjectPtr<USceneComponent> SceneComponent;
	public TMap<string,UUsdPrimTwin> Children;
	public TWeakObjectPtr<UUsdPrimTwin> Parent;
}

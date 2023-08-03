#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Unreal equivalent (twin) of a USD prim</summary>
[CppInclude("USDPrimTwin.h")]
public partial class UUsdPrimTwin : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>PrimPath</summary>
	public string PrimPath;
	///<summary>SceneComponent</summary>
	public TWeakObjectPtr<USceneComponent> SceneComponent;
	///<summary>Children</summary>
	public TMap<string,UUsdPrimTwin> Children;
	///<summary>Parent</summary>
	public TWeakObjectPtr<UUsdPrimTwin> Parent;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AMrcProjectionActor</summary>
[CppInclude("MrcProjectionBillboard.h")]
public partial class AMrcProjectionActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>ProjectionComponent</summary>
	public UMixedRealityCaptureBillboard ProjectionComponent;
	///<summary>AttachTarget</summary>
	public TWeakObjectPtr<USceneComponent> AttachTarget;
}

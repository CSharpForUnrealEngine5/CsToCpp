#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraMovementComponent.h")]
public partial class UVirtualCameraMovementComponent : UPawnMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The component we move and update when the input is coming from the controller.</summary>
	public USceneComponent RootUpdatedComponent;
	///<summary>RootUpdatedComponent, cast as a UPrimitiveComponent. May be invalid if RootUpdatedComponent was null or not a UPrimitiveComponent.</summary>
	public UPrimitiveComponent RootUpdatedPrimitive;
}

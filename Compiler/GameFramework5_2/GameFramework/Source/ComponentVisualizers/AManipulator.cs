#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Manipulator.h")]
public partial class AManipulator : AActor {
	///<summary>The component to transform when this manipulator was moved.</summary>
	public USceneComponent AssociatedComponent;
	///<summary>Visual representation of this manipulator.</summary>
	public UStaticMeshComponent StaticMeshComponent;
}

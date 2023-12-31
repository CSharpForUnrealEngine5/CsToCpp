namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Manipulator.h")]
public partial class AManipulator : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>The component to transform when this manipulator was moved.</summary>
	public USceneComponent AssociatedComponent;
	///<summary>Visual representation of this manipulator.</summary>
	public UStaticMeshComponent StaticMeshComponent;
}

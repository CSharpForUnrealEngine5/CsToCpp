#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigComponent.h")]
public partial struct FControlRigComponentMappedElement {
	public FComponentReference ComponentReference;
	public int TransformIndex;
	public string TransformName;
	public ERigElementType ElementType;
	public string ElementName;
	public EControlRigComponentMapDirection Direction;
	public FTransform Offset;
	public float Weight;
	public EControlRigComponentSpace Space;
	public USceneComponent SceneComponent;
	public int ElementIndex;
	public int SubIndex;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigComponent.h")]
public partial struct FControlRigComponentMappedElement {
	public FSoftComponentReference ComponentReference;
	public int TransformIndex;
	public FName TransformName;
	public ERigElementType ElementType;
	public FName ElementName;
	public EControlRigComponentMapDirection Direction;
	public FTransform Offset;
	public float Weight;
	public EControlRigComponentSpace Space;
	public USceneComponent SceneComponent;
	public int ElementIndex;
	public int SubIndex;
}

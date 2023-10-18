namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigControlHierarchy.h")]
public partial struct FRigControl {
	public ERigControlType ControlType;
	public FName DisplayName;
	public FName ParentName;
	public int ParentIndex;
	public FName SpaceName;
	public int SpaceIndex;
	public FTransform OffsetTransform;
	public FRigControlValue InitialValue;
	public FRigControlValue Value;
	public ERigControlAxis PrimaryAxis;
	public bool bIsCurve;
	public bool bAnimatable;
	public bool bLimitTranslation;
	public bool bLimitRotation;
	public bool bLimitScale;
	public bool bDrawLimits;
	public FRigControlValue MinimumValue;
	public FRigControlValue MaximumValue;
	public bool bGizmoEnabled;
	public bool bGizmoVisible;
	public FName GizmoName;
	public FTransform GizmoTransform;
	public FLinearColor GizmoColor;
	public TArray<int> Dependents;
	public bool bIsTransientControl;
	public UEnum ControlEnum;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyElements.h")]
public partial struct FRigControlSettings {
	public ERigControlAnimationType AnimationType;
	public ERigControlType ControlType;
	public FName DisplayName;
	public ERigControlAxis PrimaryAxis;
	public bool bIsCurve;
	public TArray<FRigControlLimitEnabled> LimitEnabled;
	public bool bDrawLimits;
	public FRigControlValue MinimumValue;
	public FRigControlValue MaximumValue;
	public bool bShapeVisible;
	public ERigControlVisibility ShapeVisibility;
	public FName ShapeName;
	public FLinearColor ShapeColor;
	public bool bIsTransientControl;
	public UEnum ControlEnum;
	public FRigControlElementCustomization Customization;
	public TArray<FRigElementKey> DrivenControls;
	public bool bGroupWithParentControl;
	public bool bRestrictSpaceSwitching;
	public TArray<ERigControlTransformChannel> FilteredChannels;
	public bool bAnimatable_DEPRECATED;
	public bool bShapeEnabled_DEPRECATED;
}

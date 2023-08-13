namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddControlVector2D_Settings {
	public ERigControlAxis PrimaryAxis;
	public FRigUnit_HierarchyAddControlVector2D_LimitSettings Limits;
	public FRigUnit_HierarchyAddControl_ShapeSettings Shape;
	public FRigUnit_HierarchyAddControl_ProxySettings Proxy;
	public TArray<ERigControlTransformChannel> FilteredChannels;
}

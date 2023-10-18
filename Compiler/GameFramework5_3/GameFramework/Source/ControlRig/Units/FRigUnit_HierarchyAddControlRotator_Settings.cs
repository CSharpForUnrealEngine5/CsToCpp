namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddControlRotator_Settings {
	public ERigVMTransformSpace InitialSpace;
	public FRigUnit_HierarchyAddControlRotator_LimitSettings Limits;
	public FRigUnit_HierarchyAddControl_ShapeSettings Shape;
	public FRigUnit_HierarchyAddControl_ProxySettings Proxy;
	public TArray<ERigControlTransformChannel> FilteredChannels;
}

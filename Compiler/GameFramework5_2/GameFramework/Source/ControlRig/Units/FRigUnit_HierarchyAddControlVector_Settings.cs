#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddControlVector_Settings {
	public bool bIsPosition;
	public FRigUnit_HierarchyAddControlVector_LimitSettings Limits;
	public FRigUnit_HierarchyAddControl_ShapeSettings Shape;
	public FRigUnit_HierarchyAddControl_ProxySettings Proxy;
	public TArray<ERigControlTransformChannel> FilteredChannels;
}

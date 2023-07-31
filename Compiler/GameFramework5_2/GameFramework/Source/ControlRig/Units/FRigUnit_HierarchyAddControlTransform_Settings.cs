#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddControlTransform_Settings {
	public FRigUnit_HierarchyAddControl_ShapeSettings Shape;
	public FRigUnit_HierarchyAddControl_ProxySettings Proxy;
	public TArray<ERigControlTransformChannel> FilteredChannels;
}

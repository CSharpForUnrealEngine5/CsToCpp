#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Controller/RCControllerContainer.h")]
///<summary>Controller Container which holds all virtual controller properties</summary>
public partial class URCControllerContainer : URCVirtualPropertyContainerBase {
// RCControllerContainer
	public float VectorSliderDelta;
	public float VectorLinearDeltaSensitivity;
	public float RotatorSliderDelta;
	public float RotatorLinearDeltaSensitivity;
	public TSet<URCActionContainer> SharedActionContainers;
}

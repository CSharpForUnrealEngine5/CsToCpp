#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actuators/MLAdapterActuator_Camera.h")]
///<summary>Allows an agent to rotate the camera.</summary>
public partial class UMLAdapterActuator_Camera : UMLAdapterActuator {
// MLAdapterActuator_Camera
	public FRotator HeadingRotator;
	public FVector HeadingVector;
	public bool bConsumeData;
	public bool bVectorMode;
}

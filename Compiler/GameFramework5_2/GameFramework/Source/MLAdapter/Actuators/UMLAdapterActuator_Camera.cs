#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an agent to rotate the camera.</summary>
[CppInclude("Actuators/MLAdapterActuator_Camera.h")]
public partial class UMLAdapterActuator_Camera : UMLAdapterActuator {
	///<summary>Stores the direction to point the camera as a rotator.</summary>
	public FRotator HeadingRotator;
	///<summary>Stores the direction to point the camera as a vector.</summary>
	public FVector HeadingVector;
	///<summary>If true, acting will reinitialize the HeadingRotator/Vector after reading them.</summary>
	public bool bConsumeData;
	///<summary>If true, use the HeadingVector. Otherwise, use the HeadingRotator.</summary>
	public bool bVectorMode;
}

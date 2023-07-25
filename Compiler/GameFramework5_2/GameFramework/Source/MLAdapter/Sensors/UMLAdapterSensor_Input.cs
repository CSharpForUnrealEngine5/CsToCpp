#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sensors/MLAdapterSensor_Input.h")]
///<summary>Note that this sensor doesn't buffer input state between GetObservations call</summary>
public partial class UMLAdapterSensor_Input : UMLAdapterSensor {
// MLAdapterSensor_Input
	public UGameViewportClient GameViewport;
	public bool bRecordKeyRelease;
}

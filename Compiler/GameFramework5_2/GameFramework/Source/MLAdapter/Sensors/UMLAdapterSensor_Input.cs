#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note that this sensor doesn&#39;t buffer input state between GetObservations call</summary>
[CppInclude("Sensors/MLAdapterSensor_Input.h")]
public partial class UMLAdapterSensor_Input : UMLAdapterSensor {
	public static UClass StaticClass() {return default;}
	///<summary>GameViewport</summary>
	public UGameViewportClient GameViewport;
	///<summary>bRecordKeyRelease</summary>
	public bool bRecordKeyRelease;
}

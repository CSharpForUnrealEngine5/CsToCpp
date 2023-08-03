#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>When applied to a player controller will create an AIPerception component for</summary>
[CppInclude("Sensors/MLAdapterSensor_AIPerception.h")]
public partial class UMLAdapterSensor_AIPerception : UMLAdapterSensor {
	public static UClass StaticClass() {return default;}
	///<summary>PerceptionComponent</summary>
	public UAIPerceptionComponent PerceptionComponent;
	///<summary>When set to true will only gather perception &quot;delta&quot; meaning consecutive</summary>
	public bool bSenseOnlyChanges;
}

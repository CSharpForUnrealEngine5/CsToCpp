#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureActorBase.h")]
public partial class ADMXFixtureActorBase : AActor {
	///<summary>Pushes DMX Values to the Fixture. Expects normalized values in the range of 0.0f - 1.0f</summary>
	public  void PushNormalizedValuesPerAttribute(FDMXNormalizedAttributeValueMap ValuePerAttributeMap) {}
	///<summary>InterpolateDMXComponents</summary>
	public  void InterpolateDMXComponents(float DeltaSeconds) {}
	///<summary>DMX</summary>
	public UDMXComponent DMX;
}

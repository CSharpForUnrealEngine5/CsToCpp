namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureActorBase.h")]
public partial class ADMXFixtureActorBase : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Pushes DMX Values to the Fixture. Expects normalized values in the range of 0.0f - 1.0f</summary>
	public virtual void PushNormalizedValuesPerAttribute(FDMXNormalizedAttributeValueMap ValuePerAttributeMap) {}
	///<summary>InterpolateDMXComponents</summary>
	public void InterpolateDMXComponents(float DeltaSeconds) {}
	///<summary>DMX</summary>
	public UDMXComponent DMX;
}

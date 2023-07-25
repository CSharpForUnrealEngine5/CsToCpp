#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLAdapterLibrarian.h")]
///<summary>The FMLAdapterLibrarian discovers all classes that derived from UMLAdapterAgent, UMLAdapterSensor, or UMLAdapterActuator.</summary>
public partial struct FMLAdapterLibrarian {
// MLAdapterLibrarian
	public TMap<uint,UClass> KnownSensorClasses;
	public TMap<uint,UClass> KnownActuatorClasses;
	public TArray<UClass> KnownAgentClasses;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FMLAdapterLibrarian discovers all classes that derived from UMLAdapterAgent, UMLAdapterSensor, or UMLAdapterActuator.</summary>
[CppInclude("MLAdapterLibrarian.h")]
public partial struct FMLAdapterLibrarian {
	public TMap<uint,UClass> KnownSensorClasses;
	public TMap<uint,UClass> KnownActuatorClasses;
	public TArray<UClass> KnownAgentClasses;
}

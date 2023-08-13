namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXImport.h")]
public partial class UDMXImport : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FixtureType</summary>
	public UDMXImportFixtureType FixtureType;
	///<summary>AttributeDefinitions</summary>
	public UDMXImportAttributeDefinitions AttributeDefinitions;
	///<summary>Wheels</summary>
	public UDMXImportWheels Wheels;
	///<summary>PhysicalDescriptions</summary>
	public UDMXImportPhysicalDescriptions PhysicalDescriptions;
	///<summary>Models</summary>
	public UDMXImportModels Models;
	///<summary>Geometries</summary>
	public UDMXImportGeometries Geometries;
	///<summary>DMXModes</summary>
	public UDMXImportDMXModes DMXModes;
	///<summary>Protocols</summary>
	public UDMXImportProtocols Protocols;
}

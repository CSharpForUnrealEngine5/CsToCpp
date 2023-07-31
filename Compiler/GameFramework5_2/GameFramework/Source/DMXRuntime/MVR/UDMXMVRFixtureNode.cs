#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node defines a light fixture object.</summary>
[CppInclude("MVR/Types/DMXMVRFixtureNode.h")]
public partial class UDMXMVRFixtureNode : UDMXMVRParametricObjectNodeBase {
	///<summary>The name of the object.</summary>
	public string Name;
	///<summary>The name of the file containing the GDTF information for this light fixture.</summary>
	public string GDTFSpec;
	///<summary>The name of the used DMX mode. This has to match the name of a DMXMode in the GDTF file.</summary>
	public string GDTFMode;
	///<summary>A focus point reference that this lighting fixture aims at if this reference exists.</summary>
	public FDMXOptionalGuid Focus;
	///<summary>Defines if a Object cast Shadow.</summary>
	public FDMXOptionalBool CastShadow;
	///<summary>A position reference that this lighting fixture belongs to if this reference exists.</summary>
	public FDMXOptionalGuid Position;
	///<summary>The Fixture Id of the lighting fixture. This is the short name of the fixture.</summary>
	public string FixtureID;
	///<summary>The unit number of the lighting fixture in a position.</summary>
	public int UnitNumber;
	///<summary>The container for DMX Addresses for this fixture.</summary>
	public FDMXMVRFixtureAddresses Addresses;
	///<summary>A color assigned to a fixture. If it is not defined, there is no color for the fixture.</summary>
	public FDMXOptionalColorCIE1931 CIEColor;
	///<summary>The Fixture Type ID is a value that can be used as a short name of the Fixture Type. This does not have to be unique. The default value is 0.</summary>
	public FDMXOptionalInt32 FixtureTypeId;
	///<summary>The Custom ID is a value that can be used as a short name of the Fixture Instance. This does not have to be unique. The default value is 0.</summary>
	public FDMXOptionalInt32 CustomId;
	///<summary>The container for Mappings for this fixture.</summary>
	public TArray<FDMXMVRFixtureMapping> Mappings;
	///<summary>The Gobo used for the fixture. The image ressource must apply to the GDTF standard.</summary>
	public FDMXOptionalMVRFixtureGobo Gobo;
}

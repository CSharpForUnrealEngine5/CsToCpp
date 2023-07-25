#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/Types/DMXMVRFixtureNode.h")]
///<summary>This node defines a light fixture object.</summary>
public partial class UDMXMVRFixtureNode : UDMXMVRParametricObjectNodeBase {
// DMXMVRFixtureNode
	public string Name;
	public string GDTFSpec;
	public string GDTFMode;
	public FDMXOptionalGuid Focus;
	public FDMXOptionalBool CastShadow;
	public FDMXOptionalGuid Position;
	public string FixtureID;
	public int UnitNumber;
	public FDMXMVRFixtureAddresses Addresses;
	public FDMXOptionalColorCIE1931 CIEColor;
	public FDMXOptionalInt32 FixtureTypeId;
	public FDMXOptionalInt32 CustomId;
	public TArray<FDMXMVRFixtureMapping> Mappings;
	public FDMXOptionalMVRFixtureGobo Gobo;
}

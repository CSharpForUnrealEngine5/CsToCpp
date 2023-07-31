#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a device input.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOInputConfiguration {
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOInputType InputType;
	public int KeyPortIdentifier;
}

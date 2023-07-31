#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a device output.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOOutputConfiguration {
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOOutputType OutputType;
	public int KeyPortIdentifier;
	public EMediaIOReferenceType OutputReference;
	public int ReferencePortIdentifier;
}

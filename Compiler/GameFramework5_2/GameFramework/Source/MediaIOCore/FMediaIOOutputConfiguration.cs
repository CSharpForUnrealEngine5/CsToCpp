#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaIOCoreDefinitions.h")]
///<summary>Configuration of a device output.</summary>
public partial struct FMediaIOOutputConfiguration {
// MediaIOOutputConfiguration
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOOutputType OutputType;
	public int KeyPortIdentifier;
	public EMediaIOReferenceType OutputReference;
	public int ReferencePortIdentifier;
}

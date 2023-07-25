#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaIOCoreDefinitions.h")]
///<summary>Configuration of a device input.</summary>
public partial struct FMediaIOInputConfiguration {
// MediaIOInputConfiguration
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOInputType InputType;
	public int KeyPortIdentifier;
}

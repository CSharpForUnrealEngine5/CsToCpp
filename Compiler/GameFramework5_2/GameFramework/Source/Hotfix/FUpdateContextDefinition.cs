#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpdateManager.h")]
///<summary>Update context definition loaded from config.</summary>
public partial struct FUpdateContextDefinition {
// UpdateContextDefinition
	public string Name;
	public bool bEnabled;
	public bool bCheckAvailabilityOnly;
	public bool bPatchCheckEnabled;
	public bool bPlatformEnvironmentDetectionEnabled;
	public TSet<string> AdditionalTags;
}

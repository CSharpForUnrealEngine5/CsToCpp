#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Validate tool *</summary>
[CppInclude("FractureToolEditing.h")]
public partial class UFractureValidateSettings : UFractureToolSettings {
	///<summary>Find and remove any unused geometry data</summary>
	public bool bRemoveUnreferencedGeometry;
	///<summary>Whether to collapse any clusters with only a single child</summary>
	public bool bRemoveClustersOfOne;
	///<summary>Remove dangling clusters -- Note this can invalidate caches</summary>
	public bool bRemoveDanglingClusters;
}

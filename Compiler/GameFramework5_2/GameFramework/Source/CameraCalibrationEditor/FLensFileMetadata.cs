#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileMetadata {
	public string Type;
	public string Version;
	public FLensInfoExchange LensInfo;
	public string Name;
	public ENodalOffsetCoordinateSystem NodalOffsetCoordinateSystem;
	public ELensFileUnit FxFyUnits;
	public ELensFileUnit CxCyUnits;
	public TArray<FLensFileUserMetadataEntry> UserMetadata;
}

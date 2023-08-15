namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensFileExchangeFormat.h")]
public partial struct FLensFileMetadata {
	public FName Type;
	public FName Version;
	public FLensInfoExchange LensInfo;
	public FName Name;
	public ENodalOffsetCoordinateSystem NodalOffsetCoordinateSystem;
	public ELensFileUnit FxFyUnits;
	public ELensFileUnit CxCyUnits;
	public TArray<FLensFileUserMetadataEntry> UserMetadata;
}

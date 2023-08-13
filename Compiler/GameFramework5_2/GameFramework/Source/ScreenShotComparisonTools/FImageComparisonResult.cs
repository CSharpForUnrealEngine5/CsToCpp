namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct holds the results of comparing an incoming image from a platform with an approved image that exists under the</summary>
[CppInclude("ImageComparer.h")]
public partial struct FImageComparisonResult {
	public FDateTime CreationTime;
	public string SourcePlatform;
	public string SourceRHI;
	public string IdealApprovedFolderPath;
	public string ApprovedFilePath;
	public string IncomingFilePath;
	public string ComparisonFilePath;
	public string ReportApprovedFilePath;
	public string ReportIncomingFilePath;
	public string ReportComparisonFilePath;
	public double MaxLocalDifference;
	public double GlobalDifference;
	public FImageTolerance Tolerance;
	public FText ErrorMessage;
	public int Version;
}

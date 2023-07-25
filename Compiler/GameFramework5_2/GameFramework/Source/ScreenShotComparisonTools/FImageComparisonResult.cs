#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImageComparer.h")]
///<summary>This struct holds the results of comparing an incoming image from a platform with an approved image that exists under the</summary>
public partial struct FImageComparisonResult {
// ImageComparisonResult
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
	public string ErrorMessage;
	public int Version;
}

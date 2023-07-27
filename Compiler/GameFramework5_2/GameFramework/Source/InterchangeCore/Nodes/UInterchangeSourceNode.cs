#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeSourceNode.h")]
///<summary>This class allow a translator to add general source data that describe the whole source. Pipeline can use this information.</summary>
public partial class UInterchangeSourceNode : UInterchangeBaseNode {
// InterchangeSourceNode
	public  void InitializeSourceNode(string UniqueID,string DisplayLabel) {}
	public  bool GetCustomSourceFrameRateNumerator(int AttributeValue) { return default; }
	public  bool SetCustomSourceFrameRateNumerator(int AttributeValue) { return default; }
	public  bool GetCustomSourceFrameRateDenominator(int AttributeValue) { return default; }
	public  bool SetCustomSourceFrameRateDenominator(int AttributeValue) { return default; }
	public  bool GetCustomSourceTimelineStart(double AttributeValue) { return default; }
	public  bool SetCustomSourceTimelineStart(double AttributeValue) { return default; }
	public  bool GetCustomSourceTimelineEnd(double AttributeValue) { return default; }
	public  bool SetCustomSourceTimelineEnd(double AttributeValue) { return default; }
	public  bool GetCustomAnimatedTimeStart(double AttributeValue) { return default; }
	public  bool SetCustomAnimatedTimeStart(double AttributeValue) { return default; }
	public  bool GetCustomAnimatedTimeEnd(double AttributeValue) { return default; }
	public  bool SetCustomAnimatedTimeEnd(double AttributeValue) { return default; }
	public  bool GetCustomImportUnusedMaterial(bool AttributeValue) { return default; }
	public  bool SetCustomImportUnusedMaterial(bool AttributeValue) { return default; }
}

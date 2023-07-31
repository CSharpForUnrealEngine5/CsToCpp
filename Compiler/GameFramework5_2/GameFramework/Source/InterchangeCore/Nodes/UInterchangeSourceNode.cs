#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class allow a translator to add general source data that describe the whole source. Pipeline can use this information.</summary>
[CppInclude("Nodes/InterchangeSourceNode.h")]
public partial class UInterchangeSourceNode : UInterchangeBaseNode {
	///<summary>Initialize the base data of the node</summary>
	public  void InitializeSourceNode(string UniqueID,string DisplayLabel) {}
	///<summary>Query the source frame rate numerator.</summary>
	public  bool GetCustomSourceFrameRateNumerator(int AttributeValue) { return default; }
	///<summary>Store the source frame rate numerator.</summary>
	public  bool SetCustomSourceFrameRateNumerator(int AttributeValue) { return default; }
	///<summary>Query the source frame rate denominator.</summary>
	public  bool GetCustomSourceFrameRateDenominator(int AttributeValue) { return default; }
	///<summary>Store the source frame rate denominator.</summary>
	public  bool SetCustomSourceFrameRateDenominator(int AttributeValue) { return default; }
	///<summary>Query the source time line start.</summary>
	public  bool GetCustomSourceTimelineStart(double AttributeValue) { return default; }
	///<summary>Store the source time line start.</summary>
	public  bool SetCustomSourceTimelineStart(double AttributeValue) { return default; }
	///<summary>Query the source time line end.</summary>
	public  bool GetCustomSourceTimelineEnd(double AttributeValue) { return default; }
	///<summary>Store the source time line end.</summary>
	public  bool SetCustomSourceTimelineEnd(double AttributeValue) { return default; }
	///<summary>Query the source animated time start.</summary>
	public  bool GetCustomAnimatedTimeStart(double AttributeValue) { return default; }
	///<summary>Store the source animated time start.</summary>
	public  bool SetCustomAnimatedTimeStart(double AttributeValue) { return default; }
	///<summary>Query the source animated time end.</summary>
	public  bool GetCustomAnimatedTimeEnd(double AttributeValue) { return default; }
	///<summary>Store the source animated time end.</summary>
	public  bool SetCustomAnimatedTimeEnd(double AttributeValue) { return default; }
	///<summary>Query the source animated time end.</summary>
	public  bool GetCustomImportUnusedMaterial(bool AttributeValue) { return default; }
	///<summary>Store the source animated time end.</summary>
	public  bool SetCustomImportUnusedMaterial(bool AttributeValue) { return default; }
}

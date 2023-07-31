#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each actor to process, update its mobilty with the selected value</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMobilityOperation : UDataprepOperation {
	///<summary>Type of mobility to set on actors</summary>
	public EComponentMobility MobilityType;
}

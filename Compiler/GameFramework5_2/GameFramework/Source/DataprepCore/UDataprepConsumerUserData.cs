#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UDataprepConsumerUserData is used to mark an asset or an actor to be respectively moved to a sub-folder or sub-level</summary>
[CppInclude("DataprepContentConsumer.h")]
public partial class UDataprepConsumerUserData : UAssetUserData {
	///<summary>Map for Dataprep entities to store data consumable or not by a consumer</summary>
	public TMap<string,string> Markers;
}

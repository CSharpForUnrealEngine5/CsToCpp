#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the SpawnPoints Generator when we want to leverage the points given by an EQS Query</summary>
[CppInclude("MassEntityEQSSpawnPointsGenerator.h")]
public partial class UMassEntityEQSSpawnPointsGenerator : UMassEntitySpawnDataGeneratorBase {
	public static UClass StaticClass() {return default;}
	///<summary>EQSRequest</summary>
	public FEQSParametrizedQueryExecutionRequest EQSRequest;
}

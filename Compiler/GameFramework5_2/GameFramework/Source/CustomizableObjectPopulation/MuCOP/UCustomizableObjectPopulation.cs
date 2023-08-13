namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOP/CustomizableObjectPopulation.h")]
public partial class UCustomizableObjectPopulation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the customizable object population</summary>
	public string Name;
	///<summary>List of Pupulation classes that define this population</summary>
	public TArray<FClassWeightPair> ClassWeights;
	///<summary>Returns the seed that was used to create instances in this call of the GeneratePopulation. Returns -1 if no generator was found.</summary>
	public int GeneratePopulation(TArray<UCustomizableObjectInstance> OutInstances,int NumInstancesToGenerate/*=1*/) { return default; }
	///<summary>Returns false if no generator was found</summary>
	public bool RegeneratePopulation(int Seed,TArray<UCustomizableObjectInstance> OutInstances,int NumInstancesToGenerate/*=1*/) { return default; }
	///<summary>Generator</summary>
	public UCustomizableObjectPopulationGenerator Generator;
}

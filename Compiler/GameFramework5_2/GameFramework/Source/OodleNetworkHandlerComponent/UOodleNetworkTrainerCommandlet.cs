#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OodleNetworkTrainerCommandlet.h")]
///<summary>Commandlet for processing UE packet captures, through Oodle's training API, for generating compressed state dictionaries.</summary>
public partial class UOodleNetworkTrainerCommandlet : UCommandlet {
// OodleNetworkTrainerCommandlet
	public bool bCompressionTest;
	public bool bWriteV5Dictionaries;
	public int HashTableSize;
	public int DictionarySize;
	public int DictionaryTrials;
	public int TrialRandomness;
	public int TrialGenerations;
	public bool bNoTrials;
}

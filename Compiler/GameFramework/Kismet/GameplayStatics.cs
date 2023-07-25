using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Kismet/GameplayStatics.h")]
    public partial class UGameplayStatics : UBlueprintFunctionLibrary {
        public static void PlaySoundAtLocation(
            UObject WorldContextObject, USoundBase Sound, 
            FVector Location, float VolumeMultiplier = 1.0f, 
            float PitchMultiplier = 1.0f, float StartTime = 0.0f, 
            USoundAttenuation AttenuationSettings = null, 
            USoundConcurrency ConcurrencySettings = null, 
            UInitialActiveSoundParams InitialParams = null){}
    }

}
namespace GameFramework
{
    public enum ECanBeCharacterBase
    {
        /** Character cannot step up onto this Component. */
        ECB_No,
        /** Character can step up onto this Component. */
        ECB_Yes,
        /**
         * Owning actor determines whether character can step up onto this Component (default true unless overridden in code).
         * @see AActor::CanBeBaseForCharacter()
         */
        ECB_Owner,
        ECB_MAX,

    }
}

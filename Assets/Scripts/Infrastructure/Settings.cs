public static class Settings
{
    public static float ButtonHideDuration { get; private set; }
    public static float ButtonShowDuration { get; private set; }
    
    public static void Init(SettingsSO so)
    {
        ButtonHideDuration = so.ButtonHideDuration;
        ButtonShowDuration = so.ButtonShowDuration;
    }
}

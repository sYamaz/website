namespace website.Pages.Works.Datas
{
    [Flags]
    public enum SupportPlatform
    {
        none = 0b00000000,
        iOS = 0b00000001,
        macOS = 0b00000010,
        windows = 0b00000100,
        linux = 0b00001000,
        android = 0b00010000
    }
}


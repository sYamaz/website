using System;
namespace website.Pages.Apps.Datas
{

    public record AnyAppData
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImagePath { get; set; } = "";
        public string ReadMoreURL { get; set; } = "";

        public SupportPlatform SupportPlatform { get; set; } = SupportPlatform.none;

        public AppStatus Status { get; set; } = AppStatus.underDevelop;
    }

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

    public enum AppStatus
    {
        underDevelop,
        inReview,
        release,
        endOfLife
    }
}


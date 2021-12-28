using System;
namespace website.Pages.Works.Datas
{

    public record AnyWorkData
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImagePath { get; set; } = "";
        public string ReadMoreURL { get; set; } = "";

        public SupportPlatform SupportPlatform { get; set; } = SupportPlatform.none;

        public WorkStatus Status { get; set; } = WorkStatus.underDevelop;
    }
}


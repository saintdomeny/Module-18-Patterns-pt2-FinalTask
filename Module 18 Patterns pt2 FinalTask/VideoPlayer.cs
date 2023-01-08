using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module_18_Patterns_pt2_FinalTask
{
    class VideoPlayer
    {
        public string videoUrl { private get; set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        YoutubeClient videos = new YoutubeClient();

        public async Task GetVideoInfoAsync()
        {
            try
            {
                var video = await videos.Videos.GetAsync(videoUrl);
                Title = video.Title;
                Description = video.Description;

                Console.WriteLine("Title:");
                Console.WriteLine(Title);
                Console.WriteLine("Description:");
                Console.WriteLine(Description);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task DownloadVideoAsync()
        {
            try
            {
                Console.WriteLine("Downloading video...");
                await videos.Videos.DownloadAsync(videoUrl, $"{DateTime.Now.ToString("yyyyMMddHHmmss")} - video.mp4");
                Console.WriteLine("Downloading completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

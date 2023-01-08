using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module_18_Patterns_pt2_FinalTask
{
    internal class Program
    {
        static async Task Main()
        {
            //sender
            var sender = new Sender();
            //receiver
            var videoPlayer = new VideoPlayer();
            //get url
            Console.WriteLine("Enter video Url:");
            videoPlayer.videoUrl = Console.ReadLine();

            var getVideoInfoCommand = new GetVideoInfoCommand(videoPlayer);
            var downloadVideoCommand = new DownloadVideoCommand(videoPlayer);
            //init InfoCommand
            sender.SetCommand(getVideoInfoCommand);
            //Run InfoCommand
            await sender.Run();
            //init DownloadCommand
            sender.SetCommand(downloadVideoCommand);
            //Run DownloadCommand
            await sender.Run();
            /*string link = Console.ReadLine();
            YoutubeClient videos = new YoutubeClient();
            var result = await videos.Videos.GetAsync("https://youtu.be/qL_pIuKWuL4");
            Console.WriteLine(result.Description);*/
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Patterns_pt2_FinalTask
{
    class GetVideoInfoCommand : ICommand
    {
        VideoPlayer videoPlayer;
        public GetVideoInfoCommand(VideoPlayer videoPlayer)
        {
            this.videoPlayer = videoPlayer;
        }
        public async Task ExecuteAsync()
        {
            await videoPlayer.GetVideoInfoAsync();
        }
    }
}
